   M S B A M L   `   `   `  ����   
Piggyback3!    ActivityBrowser.BrowserForm   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     E AControlLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null*c"http://schemas.heffsoft.com.au/wpf  -      AppTitle  � Title#  [  $	��768��$
��1280�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � Icon$0 */Piggyback3;component/Images/Piggyback.ico�� � 	Resources   BackgroundImage �� ImageSource j� TileMode j� Stretch j� ViewboxUnits	 j� Viewbox
 j� ViewportUnits j� Viewport  ExerciseTemplate �� ItemsSource �� Orientation � ToolTip �� Path��%f  &	       &	 �     �� $K Epack://application:,,,/Piggyback3;component/Images/BlueBackground.png��$
 Tile=�$
 None=�$ Absolute=�$	 0,0,128,128�$
 Absolute=�$ 0,0,128,128���  �� *
Children+.R��� $ 
Horizontal=�$��1q� �� $ Description�.+��� ���� $ Image��� $��2,0,0,0q�$��Center=����� $ Title�.��]� ��. .+�o� $	��Top=�.@�m� $��_File��.@�m� -   $��	ThemeMenu��$��Theme��$y�	Collapsed=�.@�m� -   $��Default�� m� 	IsChecked . �� m� -   $��Bureau Black��
 � Tag$ BureauBlack��m� -   $��Bureau Blue��$ 
BureauBlue��m� -   $��Expression Dark��$ ExpressionDark��m� -   $��Expression Light��$ ExpressionLight��m� -   $��
Shiny Blue��$ 	ShinyBlue��m� -	   $��ShinyRed��$ ShinyRed��m� -
   $��Whistler Blue��$ WhistlerBlue��m� -   $��activateMenu��$��Activate Piggyback��$ 1�� m� Icon �� $+��%/Piggyback3;component/Images/Lock.ico��m� -   $��manualActivateMenu��$!��Manually Activate Piggyback��$ 2�� �� $+��%/Piggyback3;component/Images/Lock.ico���� m� -   $��Exit Piggyback��m� -   $��beatMenu��$��_Beat��.@�m� -   $��offBeatMenuItem��$	��Off�� . $ 0��m� -   $��60bpm��$
 1000��m� -   $��120bpm��$	 500��m� $��_Help��.@�m� -   $��	aboutMenu��$��About Piggyback��m� -   $��
manualMenu��$��Piggyback Manual���  � ColumnDefinitions �� $	��128��$	��512��$	��256 ��� $
��Auto ��� .+��� -   $��gridSplitter1��$
��Auto��$��Stretch=�$��0q�$��Stretch=�$��4�� �� ResizeDirection$ Columns=�$��1��$
��Left=�]� -   $��	dockPanel��.+�  ControlLib.Accordion  -   $��ActivityPanel��$��2q�{�.  �� -   $��tabControl1��$��2��$��2q�.@��� -   $��InstructionTab��$��Instruction Sheet��.��Z� -   $��InstructionViewer��#��[ $ RH loves AF���� -   $��ActivityTab��$��Activity��.��� -   $��ActivityGrid���� -   $��RecordingTab��$��Recording Sheet��.��Z� -   $��RecordingViewer��#��[ 