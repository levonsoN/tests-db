   M S B A M L   `   `   `  ����H  DSimpleTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleTesting.WindowsSimpleTesting.Windows  5   	   =#clr-namespace:SimpleTesting.ControlSimpleTesting.Control  5   	   0    *SimpleTesting.Windows.RegisterAuthorWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimpleTesting.Windows     5   	   7control#clr-namespace:SimpleTesting.Control     5   	     � SizeToContent$  WidthAndHeight=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$ 
ToolWindow=�5   	    � Title$ Simple Testing Program��5   	   $	��389��6(   $	��324��65    � WindowStartupLocation$ CenterScreen=�6A   .��5      � $	��373��6   $��Center=�6   $
��Left=�63   $	��324��6N   .+�5   
   �� -   5         ��Name$ nameTextBox��5      $��0��6   $��
10,79,10,0q�64   $	��Top=�6H    J� RenderTransformOrigin$ 0.5,0.5&�6`   $��Center=�6�    �� TextAlignment$
 Left=�6�   ���	#FF7070706�   �� 5   
   $��Register New Author��6   $��	10,10,0,0q�6.   $��24(�6A   $
��Bold"�6O   $
��Left=�6a   $	��247��6|   $��47��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	nameLabel��5      $��Name:��6#   $��	10,53,0,0q�63   $��26��6F   $	��Top=�6R   $
��Left=�6j   $��44��6�   �� 5   
   -   5        $ passwordLabel��5      $��	Password:��6'   $��
10,197,0,0q�6;   $	��Top=�6O   $
��Left=�6g   -   'SimpleTesting.Control.CustomPasswordBox  5   
   -   5        	  Name$	 passwordBox��5   E   -   'SimpleTesting.Control.CustomPasswordBox
   PasswordChanged$ 
 PasswordBoxPasswordChanged��6�      InnerTabIndex$ 4��6$   $��21.96��66   $��10,223,10,0q�6Z   $	��Top=�6o   4  .System.Windows.Automation.AutomationProperties   Name$ passwordField��6�   ���	#FF7070706�   �� 5   
   -   5        $ repeatPasswordLabel��5      $��Repeat Password:��6-   $��
10,243,0,0q�6H   $	��Top=�6\   $
��Left=�6t     5   
   -   5        $	 repeatPasswordBox��5   7   $&
  RepeatPasswordBoxPasswordChanged��6�   $ 5��6$   $��10,269,10,0q�6R   $	��Top=�6g   $ passwordField��6   ���	#FF707070$��22��6�   �� 5   
   -   5         ��Name$ registerButton��5      $��6��6   $��Register��66   $��10,296,10,0q�6I   $��37��6z   $	��Top=�6�   ${�False��6�   $��14(�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF3F3F3��6#   � 5      $ 	#FFEBEBEB��6#    � Offset$ 0.597Q�65   � 5      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5      $ 	#FFCDCDCD��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ cancelButton��5      $��7��6   $��Cancel��65   $��10,338,10,0q�6F   $��23��6u   $	��Top=�6�   ��5       �� 5!      $	 0,1&�6&   .��5"      � $ 	#FFF3F3F3��6#   � 5#      $ 	#FFEBEBEB��6#   $ 0.597Q�65   � 5$      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5%      $ 	#FFCDCDCD��6#   $ 1Q�65   5&      5(      �� 5)   
   -	   5        $ surnameTextBox��5)      $��1��6   $��10,127,10,0q�67   $	��Top=�6L   $ 0.5,0.5&�6d   $��Center=�6�   $
 Left=�6�   ���	#FF7070706�   �� 5*   
   -
   5        $ surnameLabel��5*      $��Surname:��6&   $��
10,101,0,0q�69   $��26��6M   $	��Top=�6Y   $
��Left=�6q   $��63��6�   �� 5+   
   -   5        $ patronimycTextBox��5+       $��2��6   $��10,175,10,0q�6;   $	��Top=�6P   $ 0.5,0.5&�6h   $��Center=�6�   $
 Left=�6�   ���	#FF7070706�   �� 5,   
   -   5        $ surnameLabel_Copy��5,      $��Patronimyc:��6+   $��
10,149,0,0q�6A   $��26��6U   $	��Top=�6a   $
��Left=�6y   $��77��6�   5.      5/      