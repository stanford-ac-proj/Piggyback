   M S B A M L   `   `   `  ����E  APiggyback3, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ActivityBrowserActivityBrowser  5   	   !    ActivityBrowser.SecretAbout   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   E AControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+my"http://schemas.heffsoft.com.au/wpf  5   	   'my1clr-namespace:ActivityBrowser  5   	   -   5          � Title$  Super-Secret About Box!��5   "   $	��384��6B   $	��512��6O    � WindowStartupLocation$ CenterOwner=�5   	    � Topmost .   � 
ResizeMode$ NoResize=�6=   .��5      � -   5        $��mainGrid��5   	   ��5	      �� 5
       �� ImageSource$5 //Piggyback3;component/Images/BlueBackground.png��6    j� Stretch$
 None=�6Q    j� TileMode$
 Tile=�6`    j� Viewport$) #0,0,128.01786544893,128.01786544893�5       j� ViewportUnits$ Absolute=�6B   .+�5      �� -   5        $��	bounceBox��5      $��Stretch=�6   $��Stretch=�6<   '� 5      -   5        $��viewport3D1��5      	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
   
   Opacity$
 1Q�6      
BlurRadius$ 10Q�6'      	Direction$	 300Q�67    '� Camera 5      =� 5   
   -   5        cameraControl�� � Position$ 5,4,4.51�5   3    � LookDirection$ 
-11,-9,-105�6F    � FarPlaneDistance$	 100Q�6a    � UpDirection$ 0,1,05�5       � NearPlaneDistance$ 1Q�60    =� FieldOfView$ 70Q�6F   .x�5      g�  g� Content 5   
   t� 5      -   5        dirLightMain�� t� 	Direction$ -1,-1,-15�5   3   5   	   g� 5       5   
   � 5       � Geometry 5      k� 5      -   5        meshMain�� k� 	Positions� �    7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� 7�� k� TriangleIndices. �$     	

 k� TextureCoordinates9 �   5"       � Material 5$      u� 5%      -   5        matDiffuseMain�� u� Brush 5&      �� 5'      $ ./Images/pb_logo.png��6   5)       j� 	Transform 5+      Y� 5,      -	   5        transformGroup��.�5-      ��  �� Rotation 5.      �� 5/      -
   5        rotY�� �� Axis$ 0 1 05�5/   8    �� Angle$ 0Q�6E   51      �� 52       53      �� 54      -   5        rotX��$ 1 0 05�54   8   $ 0Q�6E   56      �� 57       58      �� 59      -   5        rotZ��$ 0 0 15�59   8   $ 0Q�6E   5;      5<      5>      5@   	   5A        ControlLib.TextMarquee  5B      -   5        $��thanksScroller��5B      $��Stretch=�6+   $	��Top=�6I   $��	0,150,0,0q�6a   $��36(�5C      $
��Bold"�6#   $��./resources/#Commodore 64)�65   
�������	 5D        5E   
   $
 1Q�6   $ 10Q�6'   $	 300Q�67   5G      r� 5H      -   5        $��mediaPlayer��5H   7   $��0��6J   $
��Left=�6U   $��0q�5I      $	��Top=�6   $��0��66   $y�Visible=�6@     r� UnloadedBehavior$  Manual=�6U   5J      5K      