   M S B A M L   `   `   `  ����  
Piggyback3!    ActivityBrowser.BrowserForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   E AControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null*c"http://schemas.heffsoft.com.au/wpf  5   	   -   5           AppTitle  � Title#  [  5   I   $	��768��5   	   $
��1280��6    � WindowStartupLocation$ CenterScreen=�6#    � WindowState$ 	Maximized=�6H    � Icon$0 */Piggyback3;component/Images/Piggyback.ico��5   	    � 	Resources 5        BackgroundImage �� ImageSource j� TileMode j� Stretch j� ViewboxUnits	 j� Viewbox
 j� ViewportUnits j� Viewport  ExerciseTemplate �� ItemsSource �� Orientation � ToolTip �� Path��%�  &	       &	 �     �� 5	      $K Epack://application:,,,/Piggyback3;component/Images/BlueBackground.png��5
      $
 Tile=�6e   $
 None=�5      $ Absolute=�6    $	 0,0,128,128�68   $
 Absolute=�6N   $ 0,0,128,128�5      �� 5       68   �� *
Children+.R�5      �� $ 
Horizontal=�6   $��1q�6,    67   �� $ Description�.+�5   
   �� ��6   �� $ Image��� 5   
   $��2,0,0,0q�6   $��Center=�6%   ��6B   �� $ Title�5   	   5      5      .��5      ]� ��. .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5   
   m� -   5        $��	ThemeMenu��5      $��Theme��6$   $y�	Collapsed=�63   .@�5      m� -   5        $��Default��5   -    m� 	IsChecked . 6>   �� 5      m� 5      -   5        $��Bureau Black��5   -   
 � Tag$ BureauBlack��6C   m� 5      -   5        $��Bureau Blue��5   -   $ 
BureauBlue��6B   m� 5      -   5        $��Expression Dark��5   -   $ ExpressionDark��6F   m� 5      -   5        $��Expression Light��5   -   $ ExpressionLight��6G   m� 5      -   5        $��
Shiny Blue��5   -   $ 	ShinyBlue��6A   m� 5      -	   5        $��ShinyRed��5   -   $ ShinyRed��6?   m� 5       -
   5        $��Whistler Blue��5    -   $ WhistlerBlue��6D   5!      m� 5"   
   -   5        $��activateMenu��5"   .   $��Activate Piggyback��6B   $ 1��6^    m� Icon 5#      �� 5$      $+��%/Piggyback3;component/Images/Lock.ico��6   5&      m� 5'   
   -   5        $��manualActivateMenu��5'   .   $!��Manually Activate Piggyback��6H   $ 2��6m    5(      �� 5)      $+��%/Piggyback3;component/Images/Lock.ico��6   5+      �� 5,   
   m� 5-   
   -   5        $��Exit Piggyback��5-   *   5.   	   m� 5/      -   5        $��beatMenu��5/      $��_Beat��6!   .@�50   
   m� -   5        $��offBeatMenuItem��50   .   $	��Off��6E    . $ 0��6c   m� 51   
   -   5        $��60bpm��51   .   $
 1000��6=   m� 52   
   -   5        $��120bpm��52   .   $	 500��6>   53   	   m� 54      $��_Help��6   .@�55   
   m� -   5        $��	aboutMenu��55   +   $��About Piggyback��6<   m� 56   
   -   5        $��
manualMenu��56   ,   $��Piggyback Manual��6>   57   	   58      � 59       � ColumnDefinitions 5:      �� 5;   
   $	��128��6   $	��512��6*   $	��256 �69   �� 5<   
   $
��Auto �6   �� 5=   
   .+�5?      �� -   5        $��gridSplitter1��5?      $
��Auto��6*   $��Stretch=�68   $��0q�6V   $��Stretch=�5@      $��4��61    �� ResizeDirection$ Columns=�6;   $��1��6U   $
��Left=�5A      ]� 5B      -   5        $��	dockPanel��5B      .+�5C   
     ControlLib.Accordion  -   5        $��ActivityPanel��5C      $��2q�6+   {�.  66   5D   	   �� 5E      -   5        $��tabControl1��5E      $��2��6&   $��2q�66   .@�5F   
   �� -   5        $��InstructionTab��5F      $��Instruction Sheet��6(   .��5G      Z� -   5        $��InstructionViewer��5G      #��[ 64   $ RH loves AF��6b   5H      �� 5I   
   -   5        $��ActivityTab��5I      $��Activity��6%   .��5J      � -   5        $��ActivityGrid��5J      5K      �� 5L   
   -   5        $��RecordingTab��5L      $��Recording Sheet��6&   .��5M      Z� -   5        $��RecordingViewer��5M      #��[ 62   5N      5O   	   5P      5Q      5R      