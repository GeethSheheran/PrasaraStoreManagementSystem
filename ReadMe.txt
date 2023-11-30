  -------------------------------------------------------------
			   CODECRAKS.COM

                  	    Readme File 
   -------------------------------------------------------------      

        (c) Codecraks.com , 2022. All rights reserved.

SUBSCRIBE OUR CHANNEL FOR MORE TUTORIALS
https://www.youtube.com/@codecraks

This document provides information for the Codecraks.com Souce Code File.

-------------------------
How to Use 
-------------------------

To Open the Souce Code File, open the Parental Folder using Visual Studio, and your good to go

------------------------
SUPPORT AND FEEDBACK 
------------------------

If you have suggestions for future projects and videos, e-mail to contact@codecraks.com

------------------------
CODES
------------------------

----Add this to your top of your program----

	using System.Runtime.InteropServices;

----Add this to your public partial class (Your Form name) : Form----

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

       	 private static extern IntPtr CreateRoundRectRgn
         (
        	  int nLeftRect,
        	  int nTopRect,
        	  int nRightRect,
        	  int nBottomRect,
        	  int nWidthEllipse,
       	  int nHeightEllipse

          );

----Add this after your InitializeComponent(); of the program----

	Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));