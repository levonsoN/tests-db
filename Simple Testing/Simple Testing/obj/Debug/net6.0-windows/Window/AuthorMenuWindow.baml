   M S B A M L   `   `   `  ����H  DSimpleTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleTesting.WindowsSimpleTesting.Windows  5   	   ,    &SimpleTesting.Windows.AuthorMenuWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimpleTesting.Windows     5   	   *   $SimpleTesting.Windows.EscEnterWindow    IsVisibleChanged$  WindowIsVisibleChanged��5   A    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$ 
ToolWindow=�5
   	    � SizeToContent$ WidthAndHeight=�5   	    � Title$ Simple Testing Program��5   	   $	��255��6(   $	��355��65   .��5      � $	��240��6   $	��Top=�6   $��Center=�60   $	��355��6M   .+�5   
   �� $��Author's Menu��6   $��	10,10,0,0q�6(   $��24(�6;   $
��Bold"�6I   $��42��6[   $	��Top=�6g   $
��Left=�6   $	��180��6�   �� 5   
   $��Profile��6   $��0,52,0,0q�6$   $	��107��66   $	��Top=�6C   $��Center=�6[   $	��335��6x   $��14(�6�   $
��Bold"�6�   ���	#FF707070.��5      � $��81��6   $��0,0,-2,0q�6   .+�5      �� -   5         ��Name$ authorSurnameLabel��5      $��Surname:��64   $
��Left=�6H   $	��Top=�6c   $	��317��6{   $��27��6�   $��12(�6�   $��Normal"�6�   �� 5      -   5        $ authorNameLabel��5      $��Name:��61   $
��Left=�6B   $��Center=�6]   $	��319��6x   $��27��6�   $��Normal"�6�   $��12(�6�   �� 5      -   5        $ authorPatronimycLabel��5      $��Patronimyc:��67   $
��Left=�6N   $	��Top=�6i   $	��317��6�   $��27��6�   $��0,54,0,0q�6�   $��12(�6�   $��Normal"�6�   5      5      �� 5   
   -   5         ��Name$ openTestsListButton��5      $��0��6   $��Open Tests List��6;   $��Center=�6U   $��	0,164,0,0q�6r   $	��Top=�6�   $	��335��6�   $��39��6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      � 	 � Color$	 	#FFF3F3F3��6#   � 5      $	 	#FFEBEBEB��6#   
 � Offset$	
 0.5Q�65   � 5      $	 	#FFDDDDDD��6#   $	
 0.9Q�65   � 5      $	 	#FFCDCDCD��6#   $
 1Q�65   5      5       �� 5!   
   -   5        $ editProfileButton��5!      $��1��6   $��Edit Profile��6:   $��
10,208,0,0q�6Q   $	��Top=�6e   $
��Left=�6}   $	��225��6�   ��5"      �� 5#      $	 0,1&�6&   .��5$      � $	 	#FFF3F3F3��6#   � 5%      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 5&      $	 	#FFDDDDDD��6#   $	
 0.9Q�65   � 5'      $	 	#FFCDCDCD��6#   $
 1Q�65   5(      5*      �� 5+   
   -   5        $ logOutButton��5+      $��2��6   $��Log Out��65   $��240,208,0,0q�6G   $	��Top=�6\   $
��Left=�6t   $	��105��6�   ��5,      �� 5-      $	 0,1&�6&   .��5.      � $	 	#FFF3F3F3��6#   � 5/      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 50      $	 	#FFDDDDDD��6#   $	
 0.9Q�65   � 51      $	 	#FFCDCDCD��6#   $
 1Q�65   52      54      55      56      