   M S B A M L   `   `   `  ����H  DSimpleTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleTesting.WindowsSimpleTesting.Windows  5   	   =#clr-namespace:SimpleTesting.ControlSimpleTesting.Control  5   	   ,    &SimpleTesting.Windows.EditAuthorWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimpleTesting.Windows     5   	   7control#clr-namespace:SimpleTesting.Control     5   	   *   $SimpleTesting.Windows.EscEnterWindow    IsVisibleChanged$  WindowIsVisibleChanged��5   M    � SizeToContent$ WidthAndHeight=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � Title$ Simple Testing Program��5   	    � WindowStartupLocation$ CenterScreen=�6(   $	��415��6w   .��5      � $��399.04��6   $	��324��6   .+�5   
   �� -   5         ��Name$ nameTextBox��5      $��0��6   $��
10,79,10,0q�64   $	��Top=�6H    J� RenderTransformOrigin$ 0.5,0.5&�6`   $��Center=�6�    �� TextAlignment$
 Left=�6�   ���	#FF707070$��2��6�   �� 5   
   $��Edit Profile��6   $��	10,10,0,0q�6'   $��24(�6:   $
��Bold"�6H   $
��Left=�6Z   $	��247��6u   $��47��6�   $	��Top=�6�   $��2��6�   �� 5   
   -   5        	 ��Name$	 	nameLabel��5      $��Name:��6#   $��	10,53,0,0q�63   $��26��6F   $	��Top=�6R   $
��Left=�6j   $��44��6�   �� 5   
   -   5        $	 passwordLabel��5      $��New Password:��6'   $��
10,223,0,0q�6?   $	��Top=�6S   $
��Left=�6k   ${�False��6�   -   'SimpleTesting.Control.CustomPasswordBox  5   
   -   5        
  Name$
 passwordBox��5   6   -   'SimpleTesting.Control.CustomPasswordBox   PasswordChanged$  PasswordBoxPasswordChanged��6�      InnerTabIndex$ 4��6$   $��10,249,10,0q�6K   $	��Top=�6`   4  .System.Windows.Automation.AutomationProperties   Name$ passwordField��6x   ���	#FF707070${�False��6�   $��22��6�   �� 5   
   -   5        $	 repeatPasswordLabel��5      $��Repeat Password:��6-   $��
10,269,0,0q�6H   $	��Top=�6\   $
��Left=�6t   ${�False��6�     5   
   -   5        $
 repeatPasswordBox��5   6   $&  RepeatPasswordBoxPasswordChanged��6�   $ 5��6$   $��10,295,10,0q�6Q   $	��Top=�6f   $ passwordField��6~   ���	#FF707070${�False��6�   $��22��6  �� 5   
   -   5         ��Name$ 
saveButton��5      $��6��6   $��Save Changes��62   $��10,322,10,0q�6I   $��37��6v   $	��Top=�6�   ${�False��6�   $��14(�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF3F3F3��6#   � 5      $ 	#FFEBEBEB��6#    � Offset$ 0.597Q�65   � 5      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5      $ 	#FFCDCDCD��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ cancelButton��5      $��8��6   $��Cancel��64   $��200,364,10,0q�6E   $��23��6u   $	��Top=�6�   ��5       �� 5!      $	 0,1&�6&   .��5"      � $ 	#FFF3F3F3��6#   � 5#      $ 	#FFEBEBEB��6#   $ 0.597Q�65   � 5$      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5%      $ 	#FFCDCDCD��6#   $ 1Q�65   5&      5(      �� 5)   
   -	   5        $ surnameTextBox��5)      $��1��6   $��10,127,10,0q�67   $	��Top=�6L   $ 0.5,0.5&�6d   $��Center=�6�   $
 Left=�6�   ���	#FF707070$��2��6�   �� 5*   
   -
   5        $	 surnameLabel��5*      $��Surname:��6&   $��
10,101,0,0q�69   $��26��6M   $	��Top=�6Y   $
��Left=�6q   $��63��6�   �� 5+   
   -   5        $ patronimycTextBox��5+      $��2��6   $��	0,175,0,0q�6:   $	��Top=�6M   $ 0.5,0.5&�6e   $��Center=�6�   $
 Left=�6�   ���	#FF707070$��Center=�6  $	��304��6  �� 5,   
   -   5        $	 surnameLabel_Copy��5,      $��Patronimyc:��6+   $��
10,149,0,0q�6A   $��26��6U   $	��Top=�6a   $
��Left=�6y   $��77��6�   �� 5-   
   -   5         ��Name$ changePasswordCheckBox��5-   !   $��3��6   $��Change Password��6A   $
��Left=�6[   $	��Top=�6v   $��
10,202,0,0q�6�   6�   �� 5.   
   -   5        $ deleteButton��5.      $��7��6   $��Delete Profile��64   $��10,364,129,0q�6M   $��23��6}   $	��Top=�6�   ��5/      �� 50      $	 0,1&�6&   .��51      � $ 	#FFF3F3F3��6#   � 52      $ 	#FFEBEBEB��6#   $ 0.597Q�65   � 53      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 54      $ 	#FFCDCDCD��6#   $ 1Q�65   55      57      59      5:      