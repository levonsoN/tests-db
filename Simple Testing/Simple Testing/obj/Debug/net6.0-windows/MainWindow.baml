   M S B A M L   `   `   `  ����H  DSimpleTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SimpleTestingSimpleTesting  5   	   =#clr-namespace:SimpleTesting.ControlSimpleTesting.Control  5   	   =#clr-namespace:SimpleTesting.WindowsSimpleTesting.Windows  5   	       SimpleTesting.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SimpleTesting     5   	   7control#clr-namespace:SimpleTesting.Control     5   	   7windows#clr-namespace:SimpleTesting.Windows     5   	   *   $SimpleTesting.Windows.EscEnterWindow    IsVisibleChanged$  WindowIsVisibleChanged��5   "    � Title$ Simple Testing Program��5
   	   $	��242��6(   $	��337��65    � SizeToContent$ WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ 
ToolWindow=�5   	    � WindowStartupLocation$ CenterScreen=�6L   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��336 �6    � RowDefinitions 5   
   �� 5      $	��227 �6   .+�5   
   �� -   5         ��Name$ registerButton��5      $��3��6   $��Register new author��66   $��	10,0,0,10q�6T   $��Bottom=�6g   $
��Left=�6�   $	��153��6�   $��23��6�   ��5      �� 5      	 �� EndPoint$		 0,1&�6&   .��5      � 
 � Color$
 	#FFF3F3F3��6#   � 5      $
 	#FFEBEBEB��6#    � Offset$ 0.597Q�65   � 5      $
 	#FFDDDDDD��6#   $	 0.9Q�65   � 5      $
 	#FFCDCDCD��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ logInButton��5      $��2��6   $��Log in��63   $��10,151,10,38q�6D   $��14(�6s   ��5       �� 5!      $		 0,1&�6&   .��5"      � $
 	#FFF3F3F3��6#   � 5#      $
 	#FFEBEBEB��6#   $ 0.597Q�65   � 5$      $
 	#FFDDDDDD��6#   $	 0.9Q�65   � 5%      $
 	#FFCDCDCD��6#   $ 1Q�65   5&      5(      �� 5)   
   -   5         ��Name$ namesComboBox��5)       $��0��6   $��
10,77,10,0q�67   $	��Top=�6K    J� RenderTransformOrigin$ 0.5,0.5&�6c   $
��Left=�6�   ��5*      �� 5+      $		 0,1&�6&   .��5,      � $
 	#FFF3F3F3��6#   � 5-      $
 	#FFEBEBEB��6#   $	 0.5Q�65   � 5.      $
 	#FFDDDDDD��6#   $	 0.9Q�65   � 5/      $
 	#FFCDCDCD��6#   $ 1Q�65   50      z�52      V� 53      .~�54      �� �� 55       �� AngleY$ 0.313Q�6$   �� 56       �� Angle$ -0.169Q�6&   T� 57       T� Y$ 0.328Q�6)   58      5:      �� 5;   
   -   5        $ takeTestButton��5;      $��4��6   $��Take a test��66   $��	0,0,10,10q�6L   $��Right=�6_   $	��153��6{   $��23��6�   $��Bottom=�6�   ��5<      �� 5=      $		 0,1&�6&   .��5>      � $
 	#FFF3F3F3��6#   � 5?      $
 	#FFEBEBEB��6#   $ 0.597Q�65   � 5@      $
 	#FFDDDDDD��6#   $	 0.9Q�65   � 5A      $
 	#FFCDCDCD��6#   $ 1Q�65   5B      5D      �� 5E   
   $��Log in as Author��6   $��10,10,130,175q�6+   $��24(�6B   $
��Bold"�6P   �� 5F   
   -   5         ��Name$ 	nameLabel��5F      $��Name:��6#   $��	10,52,0,0q�63   $��26��6F   $	��Top=�6R   $
��Left=�6j   $��44��6�   �� 5G   
   -   5        $ passwordLabel��5G      $��	Password:��6'   $��	10,99,0,0q�6;   $	��Top=�6N   $
��Left=�6f   -   'SimpleTesting.Control.CustomPasswordBox  5H   
   -   5          Name$ passwordBox��5H   6   -   'SimpleTesting.Control.CustomPasswordBox   PasswordChanged$  PasswordBoxPasswordChanged��6�      InnerTabIndex$ 1��6$   $��10,124,10,0q�6K   $��22��6`   $	��Top=�6l   $ 0.5,0.5&�6�   6�   5I      5J      