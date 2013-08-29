using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSplitter
{
 

    public partial class Form1 : Form
    {
        public Decimal SplitWidth { get; set; }
        public Decimal SplitHeight { get; set; }
        public Boolean DrawGrid { get; set; }
        public Decimal SplitPadding { get; set; }

        Image sourceImage;
        Image[,] pieces;
       
        public Form1()
        {
            InitializeComponent();

            sourceImage = null;

            //Designer Values
            SplitWidth = (int)SettingUpDownWidth.Value;
            SplitHeight = (int)SettingsUpDownHeight.Value;
            DrawGrid = ShowGridCheckBox.Checked;
            SplitPadding = PaddingUpDown.Value;

            //DataBind Settings
            SettingUpDownWidth.DataBindings.Add(new Binding("Value", this, "SplitWidth", false, DataSourceUpdateMode.OnPropertyChanged));
            SettingsUpDownHeight.DataBindings.Add(new Binding("Value", this, "SplitHeight", false, DataSourceUpdateMode.OnPropertyChanged));
            ShowGridCheckBox.DataBindings.Add(new Binding("Checked", this, "DrawGrid", false, DataSourceUpdateMode.OnPropertyChanged));
            PaddingUpDown.DataBindings.Add(new Binding("Value", this, "SplitPadding", false, DataSourceUpdateMode.OnPropertyChanged));

        }

      

        private void OpenButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
               
                sourceImage = Image.FromFile(path);
              
                SourceImageBox.Invalidate();
            }
            openFileDialog1.Dispose();
        }



        private void SplitButton_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                return;
            }

            //Calc Grid dimensions
            Point dims = new Point();
            dims.X = (int)Math.Ceiling(sourceImage.Width / SplitWidth);
            dims.Y = (int)Math.Ceiling(sourceImage.Height / SplitHeight);

            pieces = new Image[dims.Y, dims.X];

            //Split Image
            for (int y = 0; y < dims.Y; y++)
            {
                for (int x = 0; x < dims.X; x++)
                {
                    pieces[y,x] = new Bitmap((int)SplitWidth, (int)SplitHeight);
                    var g = Graphics.FromImage(pieces[y,x]);
                    g.DrawImage(sourceImage, new Rectangle(0, 0, (int)SplitWidth, (int)(SplitHeight)), new Rectangle(x * (int)SplitWidth, y * (int)SplitHeight, (int)SplitWidth, (int)SplitHeight), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            }
            SplitImageBox.Invalidate();
        }



        private void ExportButton_Click(object sender, EventArgs e)
        {

            //FIX - folder browser opens behind application when used after filebrowser
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = folderBrowserDialog1.ShowDialog( this.Parent );
            
            if (dr == DialogResult.OK && pieces != null)
            {
                string path = folderBrowserDialog1.SelectedPath;
                string extension = ".jpg"; //default to jpg. will change later.

                //write peices into folder
                int c = 1;
                for (int y = 0; y < pieces.GetLength(0); y++)
                {
                    for (int x = 0; x < pieces.GetLength(1); x++)
                    {
                        string name = "img" + c; c++;
                        pieces[y,x].Save( path + "/" + name + extension );
                    }
                }

            }
        }



        private void ShowGridCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            //Force a Redraw of Source image
            SourceImageBox.Invalidate();
        }



        private void SettingUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            SourceImageBox.Invalidate();
        }



        private void SettingsUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            SourceImageBox.Invalidate();
        }



        private void PaddingUpDown_ValueChanged(object sender, EventArgs e)
        {
            SplitImageBox.Invalidate();
        }



        private void SourceImageBox_Paint(object sender, PaintEventArgs e)
        {
            //Null Source Image Check
            if (sourceImage == null)
            {
                return;
            }
            //Set Image
            //SourceImageBox.Image = sourceImage;
            var g = e.Graphics;
            g.DrawImage(sourceImage, new Rectangle(0,0, sourceImage.Width, sourceImage.Height) ); //bounding rectangle to force DPI

            //Check for draw grid
            if (DrawGrid == false)
            {
                return;
            }

            //Calc Grid dimensions
            Point dims = new Point();
            dims.X = (int)Math.Ceiling(sourceImage.Width / SplitWidth);
            dims.Y = (int)Math.Ceiling(sourceImage.Height / SplitHeight);

            //Draw Preview Grid
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (int y = 0; y < dims.Y ; y++)
            {
                for (int x = 0 ; x < dims.X; x++)
                {
                    Rectangle guide = new Rectangle(x * (int)SplitWidth, y * (int)SplitHeight, (int)SplitWidth, (int)SplitHeight);
                    g.DrawRectangle(pen, guide);
                }
            }
        }



        private void SplitImageBox_Paint(object sender, PaintEventArgs e)
        {
            //Not peices check
            if (pieces == null)
            {
                return;
            }

            //Draw
            var g = e.Graphics;
            for (int y = 0; y < pieces.GetLength(0); y++)
            {
                for (int x = 0; x < pieces.GetLength(1); x++)
                {
                    //Draw with "SplitPadding" distance between each peice
                    g.DrawImage(pieces[y, x], x*(int)SplitWidth + x*(int)SplitPadding, y*(int)SplitHeight + y*(int)SplitPadding);
                }
            }
        }



    }
}
