using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorObjectPlotter
{
    public partial class Form1 : Form
    {
        //we'll need to store coordinates in a list of some sort
        //color for all icons: #4f4f4f generated from here:  http://fa2png.io/
        private List<Point> _coordinates = new List<Point>();
        private bool _showGrid = false;
        private int _gridSpacing = 5;
        private int _cursorPosition = 0;
        private bool _showXY = true;
        private bool _showCoords = false;
        private float _scale = 1; // holds value to either increase or decrease the image size

        public Form1()
        {
            InitializeComponent();
        }


        private void pbCanvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.PageScale = _scale;


            g.PageUnit = GraphicsUnit.Pixel;

            //label1.Text = pbCanvas.Width.ToString();
           

            

            //check to see whether we should show grid lines
            if (_showGrid)
            {
                int numOfCells = 200;
                int cellSize = _gridSpacing ;
                Pen p = new Pen(Color.Blue);

                for (int y = 0; y < numOfCells; ++y)
                {
                    g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
                }

                for (int x = 0; x < numOfCells; ++x)
                {
                    g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
                }
            }

            

            if (_showXY)
            {
                Point topCenter = new Point(GetCanvasWidth() / 2, 0);
                    Point leftCenter = new Point(0, GetCanvasWidth() / 2);
                    Point rightCenter = new Point(GetCanvasWidth(), GetCanvasWidth() / 2);
                    Point bottomCenter = new Point(GetCanvasWidth() / 2, GetCanvasWidth() * 2);

                    g.DrawLine(System.Drawing.Pens.Red, topCenter.X, topCenter.Y,
                   bottomCenter.X, bottomCenter.Y);

                    g.DrawLine(System.Drawing.Pens.Red, leftCenter.X, leftCenter.Y,
                       rightCenter.X, rightCenter.Y);
                
            }

            if (_coordinates.Count > 1)
            {
                for (var i = 0; i < _coordinates.Count - 1; i++)
                {
                    //need to account for image scaling here...
                    //var convertedCoord = ScaleFromPictureBox(_coordinates[i]);
                    //var scaledCoord = ScaleCoordinate(convertedCoord);
                    //scaledCoord = ScaleToPictureBox(scaledCoord);

                    //var nextConvertedCoord = ScaleFromPictureBox(_coordinates[i + 1]);
                    //var nextScaledCoord = ScaleCoordinate(nextConvertedCoord);
                    //nextScaledCoord = ScaleToPictureBox(nextScaledCoord);


                    //g.DrawLine(System.Drawing.Pens.Black, scaledCoord.X, scaledCoord.Y,
                    //    nextScaledCoord.X, nextScaledCoord.Y);

                    g.DrawLine(System.Drawing.Pens.Black, _coordinates[i].X, _coordinates[i].Y,
                        _coordinates[i + 1].X, _coordinates[i + 1].Y);
                }
            }

            //check to see if we should show the coordinate points on the object
            if (_showCoords)
            {
                //loop through coordinates and plot them on the map
                if (_coordinates.Count > 0)
                {
                    foreach (var coord in _coordinates)
                    {
                        //scaledCoord for display purposes
                        var scaledCoord = ScaleFromPictureBox(coord,true);
                        g.DrawString("(" + (scaledCoord.X) + "," + (scaledCoord.Y) + ")", new Font("Arial", 10), new SolidBrush(Color.Green), coord);
                    }
                }
            }

            OutputCoordinates();

            if (_cursorPosition != 0)
            {
                rtbOutput.SelectionStart = _cursorPosition;
            }

            

        }

        /// <summary>
        /// gets the correct canvas width
        /// </summary>
        /// <param name="fromPaint">if param is true then it's coming from the Paint routine, need to use canvaswidth.text</param>
        /// <returns></returns>
        private int GetCanvasWidth(bool fromPaint = true)
        {
            int width = pbCanvas.Width ;

            if(fromPaint)
                int.TryParse(canvasWidth.Text, out width);
            
            return width;
        }

        private int GetCanvasHeight()
        {
            int height = pbCanvas.Height;
           
            int.TryParse(canvasHeight.Text, out height);

            return height;
        }

        //private Point ScaleCoordinate(Point coordToScale)
        //{
        //    //figure out which quadrant the point lies in
        //    if (coordToScale.X >= 0 && coordToScale.Y >= 0)
        //    {
        //        //we're in quadrant 1
        //        return new Point(coordToScale.X + _scale , coordToScale.Y + _scale );
        //    }
        //    else if (coordToScale.X < 0 && coordToScale.Y >= 0)
        //    {
        //        //we're in quadrant 2
        //        return new Point(coordToScale.X - _scale, coordToScale.Y + _scale);
        //    }
        //    else if (coordToScale.X < 0 && coordToScale.Y < 0)
        //    {
        //        //we're in quadrant 3
        //        return new Point(coordToScale.X - _scale, coordToScale.Y - _scale);
        //    }
        //    else if (coordToScale.X >= 0 && coordToScale.Y < 0)
        //    {
        //        //we're in quadrant 4
        //        return new Point(coordToScale.X + _scale, coordToScale.Y - _scale);
        //    }

        //    return new Point(coordToScale.X >= 0 ? coordToScale.X + _scale : coordToScale.X - _scale, coordToScale.Y >= 0 ? coordToScale.Y + _scale : coordToScale.Y - _scale);


        //}

        private void pbCanvas_Click(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            coordinates.X = coordinates.X / (int)_scale;
            coordinates.Y = coordinates.Y / (int)_scale;

            _coordinates.Add(coordinates);

            pbCanvas.Invalidate();



        }

        /// <summary>
        /// Function to convert the picture box coords to cartesian with 0,0 in center etc
        /// </summary>
        /// <param name="pbCoordinate"></param>
        /// <returns></returns>
        private Point ScaleFromPictureBox(Point pbCoordinate, bool fromPaint)
        {
            var newCoord = new Point((pbCoordinate.X - (GetCanvasWidth(fromPaint) / 2)), -(pbCoordinate.Y - (GetCanvasWidth(fromPaint) / 2)));
            //var newCoord = new Point((pbCoordinate.X - (pbCanvas.Width / 2)), -(pbCoordinate.Y - (pbCanvas.Width / 2)));

            //check page scaling too


            return newCoord;
        }

        /// <summary>
        /// Function to convert the cartesian coords to picture box with 0,0 at top left etc
        /// </summary>
        /// <param name="cartCoordinate"></param>
        /// <returns></returns>
        private Point ScaleToPictureBox(Point cartCoordinate)
        {
            var newCoord = new Point((cartCoordinate.X + (GetCanvasWidth() / 2)), -(cartCoordinate.Y - (GetCanvasHeight() / 2)));

            return newCoord;
        }

        private void pbCanvas_MouseMove(object sender, System.EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;


            var scaledCoord = ScaleFromPictureBox(coordinates, false);
            scaledCoord.X = scaledCoord.X / (int)_scale;
            scaledCoord.Y = scaledCoord.Y / (int)_scale;
            lblCurrentPosition.Text = scaledCoord.X + " , " + scaledCoord.Y;
            

            coordinates.X = coordinates.X / (int)_scale;
            coordinates.Y = coordinates.Y / (int)_scale;


            if (_coordinates.Count > 0)
            {
                //need to somehow clear existing blue lines
                Graphics g = pbCanvas.CreateGraphics();

                g.PageScale = _scale;


                g.PageUnit = GraphicsUnit.Pixel;

                bool foundAMatch = false; //keeps track of whether or not we found a match

                //check to see if current coordinate matches any other point entered
                //if it does then draw a blue line between the two points
                //as a suggestion
                Point foundXPoint = _coordinates.Find(x => x.X == coordinates.X );
                Point foundYPoint = _coordinates.Find(x => x.Y == coordinates.Y );
                if (foundXPoint != null && (foundXPoint.X != 0 && foundXPoint.Y != 0))
                {
                    //found a matching x point
                    foundAMatch = true;
                    g.DrawLine(System.Drawing.Pens.Blue, coordinates.X, coordinates.Y,
                        foundXPoint.X, foundXPoint.Y);
                }

                if (foundYPoint != null && (foundYPoint.X != 0 && foundYPoint.Y != 0))
                {
                    //found a matching y point
                    foundAMatch = true;

                    g.DrawLine(System.Drawing.Pens.Blue, coordinates.X , coordinates.Y ,
                        foundYPoint.X, foundYPoint.Y);
                }

                if (!foundAMatch)
                {
                    pbCanvas.Invalidate();
                }
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ReSizeCanvas();

            CenterCanvas(); 

            cboExportFormat.SelectedIndex = 0;

            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterCanvas(); 


        }

        private void ReSizeCanvas()
        {
            // Adjust picture size'
            int width = 256,
                height = 256;

            int.TryParse(canvasWidth.Text, out width);
            int.TryParse(canvasHeight.Text, out height);

            //if page has been scaled, need to account for scaling
            if (_scale > 1)
            {
                width = width *  (int)_scale;
                height = height * (int)_scale;

            }

          

            pbCanvas.Width = width;
            pbCanvas.Height = height;

          


            CenterCanvas();

            
           
        }

        private void pbCanvas_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Graphics dc = CreateGraphics();
            //dc.TranslateTransform(this.AutoScrollPosition.X / m_Scalef,
            //  this.AutoScrollPosition.Y / m_Scalef);
            //dc.PageUnit = GraphicsUnit.Pixel;
            //dc.PageScale = m_Scalef;

            //Point[] mousep = new Point[1];
            //// make sure to adjust mouse pos.for scroll position
            //Size scrollOffset = new Size(this.AutoScrollPosition);
            //mousep[0] = new Point(e.X - scrollOffset.Width, e.Y - scrollOffset.Height);

            //dc.TransformPoints(CoordinateSpace.Page, CoordinateSpace.Device, mousep);
            //Pen pen = new Pen(Color.Green, 1);
            //dc.DrawRectangle(pen, m_r1);
            //if (m_r1.Contains(new Rectangle(mousep[0].X, mousep[0].Y, 1, 1)))
            //    MessageBox.Show("click inside rectangle");
        }

        private void CenterCanvas()
        {
              pbCanvas.Location = new Point((pbCanvas.Parent.ClientSize.Width / 2) - (pbCanvas.Width / 2),
                                        50);

            pbCanvas.Refresh();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_coordinates.Count > 0)
                _coordinates.RemoveAt(_coordinates.Count - 1);

            pbCanvas.Invalidate();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _coordinates.Clear();
            _scale = 1F;

            ReSizeCanvas();

            pbCanvas.Invalidate();
        }

        private void canvasWidth_KeyPress(object sender, EventArgs e)
        {
            ReSizeCanvas();
        }

        private void canvasHeight_KeyUp(object sender, EventArgs e)
        {
            ReSizeCanvas();
        }

        private void OutputCoordinates()
        {
            var sBuilder = new StringBuilder();
            //first clear the rich text box
            rtbOutput.Clear();


            if (_coordinates.Count > 1)
            {
                for (var i = 0; i < _coordinates.Count; i++)
                {
                    var scaledCoord = ScaleFromPictureBox(_coordinates[i],true);

                    //need a function that will convert format to polar if necessary
                    if (cboExportFormat.SelectedText == "Cartesian (x, y)" || cboExportFormat.SelectedIndex == 0)
                    {
                       
                             //sBuilder.AppendLine(scaledCoord.X + "," + scaledCoord.Y);
                        if (chkLineBreak.Checked)
                        {
                            sBuilder.AppendLine(ApplyFormat(scaledCoord.X, scaledCoord.Y));
                        }
                        else
                        {
                            sBuilder.Append(ApplyFormat(scaledCoord.X, scaledCoord.Y));
                        }

                        
                    }
                    else
                    {
                        //convert to polar
                        var converted = ConvertToPolar(scaledCoord);
                        
                        //uzebox only uses 256 degrees instead of 360, so we have to divide by 1.41 to get our true angle
                        double newAngle = converted.Y;
                        newAngle = newAngle / 1.41;

                        
                        converted.Y = (int)Math.Round((decimal)newAngle, 0);

                            //sBuilder.AppendLine(converted.X + "," + converted.Y);
                        if (chkLineBreak.Checked)
                        {
                            sBuilder.AppendLine(ApplyFormat(converted.X , converted.Y));
                        }
                        else
                        {
                            sBuilder.Append(ApplyFormat(converted.X, converted.Y));
                        }
                        

                        
                    }


                
                }

              
                     rtbOutput.Text = sBuilder.ToString();
               

               
            }
        }

        /// <summary>
        /// used to format output with supplied regular expression entered by user
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private string ApplyFormat(int x, int y)
        {
            string replace = toolStripTextBox3.Text;

            replace = replace.Replace("<x>", x.ToString());
            replace = replace.Replace("<y>", y.ToString());

            return replace;
        }

        /// <summary>
        /// Converts a cartesian coord to a polar coord
        /// </summary>
        /// <param name="cartXY"></param>
        /// <returns></returns>
        private Point ConvertToPolar(Point cartXY)
        {
            //first solve for longest side using pythagorean theorem  
            //see here for explanation: http://www.mathsisfun.com/polar-cartesian-coordinates.html

            double r = Math.Sqrt((cartXY.X * cartXY.X) + (cartXY.Y * cartXY.Y));


            decimal ratio = decimal.Round((decimal)cartXY.Y / (decimal)cartXY.X, 4);
            double angle = Math.Atan((double)ratio) * 180 / Math.PI;

            //depending on which quadrant the coord is in we'll need to add 180 or 360 to the final angle

            //if x and y are both positive we're in quadrant 1 and we don't have to do anything
            if (cartXY.X >= 0 && cartXY.Y < 0)
            {
                //we're in quadrant 4 so add 360
                angle += 360;

            }else if( cartXY.X < 0 ){
                 //we're either in quadrant 2 or 3  so add 180
                angle += 180;
            }

            

            return new Point((int)Math.Round((decimal)r, 0), (int)Math.Round((decimal)angle, 0));
        }

        /// <summary>
        /// Converts a Polar coord to a cartesian coord
        /// </summary>
        /// <param name="polarXY"></param>
        /// <returns></returns>
        private Point ConvertToCartesian(Point polarXY)
        {
            //see here for explanation: http://www.mathsisfun.com/polar-cartesian-coordinates.html
            //x = r × cos( θ )
            //y = r × sin( θ )

            double x = polarXY.X * Math.Cos((double)polarXY.Y * (Math.PI / 180.0));   //needed to convert degree to radians
            double y = polarXY.X * Math.Sin((double)polarXY.Y * (Math.PI / 180.0));


            return new Point((int)Math.Round((decimal)x, 0), (int)Math.Round((decimal)y, 0));
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            //need to scale image and increase width/height of pbCanvas?
            //probably need a ScaleCoordinate function or something

            

            //_scale += .1F; //increment scale by 5
            _scale += 1F; //increment scale by 5

            ReSizeCanvas();
            

            pbCanvas.Invalidate();

            
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            //need to scale image and decrease width/height of pbCanvas?

            if (_scale == 1)
                return;

            //_scale -= .1F; //decrement scale by 5
            _scale -= 1F; //decrement scale by 5

            ReSizeCanvas();

            pbCanvas.Invalidate();


        }



        private void ToggleGrid(int spacing, ToolStripMenuItem sender)
        {
            bool isChecked = !sender.Checked;

            //need to uncheck other items 
            showGrid5.Checked = false;
            showGrid10.Checked = false;
            showGrid15.Checked = false;
            showGrid20.Checked = false;

            //toggle check
            sender.Checked = isChecked;

            //toggle _showGrid
            _showGrid = sender.Checked;
            _gridSpacing = spacing;

            pbCanvas.Invalidate();
        }

        private void btnLinkEnds_Click(object sender, EventArgs e)
        {
            if (_coordinates.Count > 0)
            {
                Point first = _coordinates[0];
                _coordinates.Add(first);

                pbCanvas.Invalidate();
            }

        }

        private void showGrid5_Click(object sender, EventArgs e)
        {

            ToggleGrid(5, (ToolStripMenuItem)sender);
        }

        private void showGrid10_Click(object sender, EventArgs e)
        {

            ToggleGrid(10, (ToolStripMenuItem)sender);
        }

        private void showGrid15_Click(object sender, EventArgs e)
        {

            ToggleGrid(15, (ToolStripMenuItem)sender);
        }

        private void showGrid20_Click(object sender, EventArgs e)
        {

            ToggleGrid(20, (ToolStripMenuItem)sender);
        }

        private void rtbOutput_KeyUp(object sender, EventArgs e)
        {
          
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            //if coordinates were manually typed in, then we want to
            //import them now
            _cursorPosition = rtbOutput.SelectionStart;

            var tempCoords = _coordinates.ToList();

            _coordinates.Clear();

            try
            {
                //need to use regex to pull out the coords from the default format: { <x>, <y> }, 

                string pattern = @"\{\s*?(?<x>-?\d+)\s*?\,\s*?(?<y>-?\d+)\s*?\}\s*?\,";

                pattern = toolStripTextBox3.Text;

                //now we need to fine tune the pattern so we can match our x and y coords

                pattern = pattern.Replace(@"\", @"\\");  //replacing special characters
                pattern = pattern.Replace(@".", @"\.");  //replacing special characters
                pattern = pattern.Replace(@"+", @"\+");  //replacing special characters
                pattern = pattern.Replace(@"*", @"\*");  //replacing special characters
                pattern = pattern.Replace(@"?", @"\?");  //replacing special characters
                pattern = pattern.Replace(@"[", @"\[");  //replacing special characters
                pattern = pattern.Replace(@"]", @"\]");  //replacing special characters
                pattern = pattern.Replace(@"^", @"\^");  //replacing special characters
                pattern = pattern.Replace(@"$", @"\$");  //replacing special characters
                pattern = pattern.Replace(@"(", @"\(");  //replacing special characters
                pattern = pattern.Replace(@")", @"\)");  //replacing special characters
                pattern = pattern.Replace(@"{", @"\{");  //replacing special characters
                pattern = pattern.Replace(@"}", @"\}");  //replacing special characters
                pattern = pattern.Replace(@"=", @"\=");  //replacing special characters
                pattern = pattern.Replace(@"!", @"\!");  //replacing special characters
                pattern = pattern.Replace(@"<", @"\<");  //replacing special characters
                pattern = pattern.Replace(@"\<x", @"<x");  //replacing special characters
                pattern = pattern.Replace(@"\<y", @"<y");  //replacing special characters

                pattern = pattern.Replace(@">", @"\>");  //replacing special characters
                pattern = pattern.Replace(@"x\>", @"x>");  //replacing special characters
                pattern = pattern.Replace(@"y\>", @"y>");  //replacing special characters

                
                pattern = pattern.Replace(@"|", @"\|");  //replacing special characters
                pattern = pattern.Replace(@":", @"\:");  //replacing special characters
                pattern = pattern.Replace(@"-", @"\-");  //replacing special characters

               

                pattern = pattern.Replace(" ", @"\s*?");  //replacing white space
                pattern = pattern.Replace("<x>", @"(?<x>-?\d+)");  //replace the x variable with our x group
                pattern = pattern.Replace("<y>", @"(?<y>-?\d+)");  //replace the y variable with our y group



                string input = rtbOutput.Text;
                foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(input, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                          if (cboExportFormat.SelectedText == "Cartesian (x, y)" || cboExportFormat.SelectedIndex == 0)
                        {
                            var scaledCoord = ScaleToPictureBox(new Point(int.Parse(match.Groups["x"].Value), int.Parse(match.Groups["y"].Value)));
                            _coordinates.Add(scaledCoord);
                        } 
                      else
                          {
                              //for uzebox coords we need to multiply by 1.41 since there are only 256 degrees instead of 360
                              double newAngle = int.Parse(match.Groups["y"].Value);
                              newAngle = newAngle * 1.41;

                              //convert polar to cartesian
                              Point tempCoord = ConvertToCartesian(new Point(int.Parse(match.Groups["x"].Value), (int)Math.Round((decimal)newAngle, 0)));
                              var scaledCoord = ScaleToPictureBox(tempCoord);

                              _coordinates.Add(scaledCoord);
                          }
                                     
                }
                    

                //foreach (var line in rtbOutput.Lines)
                //{
                //    if (!string.IsNullOrWhiteSpace(line))
                //    {
                //        string[] xy = line.Split(new Char[] { ',' });
                //        //check if we're using polar or cartesian format first
                //        if (cboExportFormat.SelectedText == "Cartesian (x, y)" || cboExportFormat.SelectedIndex == 0)
                //        {
                //            var scaledCoord = ScaleToPictureBox(new Point(int.Parse(xy[0]), int.Parse(xy[1])));
                //            _coordinates.Add(scaledCoord);
                //        }
                //        else
                //        {
                //            //for uzebox coords we need to multiply by 1.41 since there are only 256 degrees instead of 360
                //            double newAngle = int.Parse(xy[1]);
                //            newAngle = newAngle * 1.41;

                //            //convert polar to cartesian
                //            Point tempCoord = ConvertToCartesian(new Point(int.Parse(xy[0]), (int)Math.Round((decimal)newAngle, 0)));
                //            var scaledCoord = ScaleToPictureBox(tempCoord);

                //            _coordinates.Add(scaledCoord);
                //        }
                //    }



                //}
            }
            catch (Exception ex)
            {
                //if we get an error somewhere then just go back to the old coords
                _coordinates = tempCoords;

            }

            pbCanvas.Invalidate();
        }

        private void btnToggleXY_Click(object sender, EventArgs e)
        {
            _showXY = !_showXY;

            pbCanvas.Invalidate();
        }

        private void cboExportFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbCanvas.Invalidate();
        }

        private void btnShowCoords_Click(object sender, EventArgs e)
        {
            _showCoords = !_showCoords;

            pbCanvas.Invalidate();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Point p1 = new Point(10, 10);
            //Point p2 = new Point(-10, 10);
            //Point p3 = new Point(-10, -10);
            //Point p4 = new Point(10, -10);

            //Point scaledP1 = ScaleCoordinate(p1);
            //Point scaledP2 = ScaleCoordinate(p2);
            //Point scaledP3 = ScaleCoordinate(p3);
            //Point scaledP4 = ScaleCoordinate(p4);

            //scaledP1 = ScaleToPictureBox(scaledP1);
            //scaledP2 = ScaleToPictureBox(scaledP2);
            //scaledP3 = ScaleToPictureBox(scaledP3);
            //scaledP4 = ScaleToPictureBox(scaledP4);

            //Graphics g = pbCanvas.CreateGraphics();

            //g.DrawLine(System.Drawing.Pens.Black, scaledP1.X, scaledP1.Y,
            //           scaledP2.X, scaledP2.Y);

            //g.DrawLine(System.Drawing.Pens.Black, scaledP2.X, scaledP2.Y,
            //           scaledP3.X, scaledP3.Y);

            //g.DrawLine(System.Drawing.Pens.Black, scaledP3.X, scaledP3.Y,
            //           scaledP4.X, scaledP4.Y);

            //g.DrawLine(System.Drawing.Pens.Black, scaledP4.X, scaledP4.Y,
            //           scaledP1.X, scaledP1.Y);
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(rtbOutput.Text);
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Clipboard.GetText();
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            OutputCoordinates();
        }

        private void chkLineBreak_CheckedChanged(object sender, EventArgs e)
        {
            OutputCoordinates();
        }

       

       








    }
}
