   M S B A M L   `   `   `  ����H  DSimpleTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SimpleTesting.WindowsSimpleTesting.Windows  5   	   +    %SimpleTesting.Windows.TestsListWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SimpleTesting.Windows     5   	   -   5          � 
ResizeMode$  NoResize=�5   	    � WindowStyle$ 
ToolWindow=�5	   	    � SizeToContent$ WidthAndHeight=�5
   	    � Title$ Simple Test Program��5   	   $	��505��6%   $	��840��62   .��5      � $	��840��6   $��489.04��6   .+�5   
   �� $��
Tests List��6   $��	10,10,0,0q�6%   $��24(�68   $
��Bold"�6F   $��42��6X   $	��Top=�6d   $
��Left=�6|   $	��115��6�   �� 5   
   -   5         ��Name$ authorTextBlock��5      $��Author:��6)   $
��Left=�6<   $��
130,24,0,0q�6W   $	��Top=�6k   $	��445��6�   $��27��6�   �� 5   
   -   5         ��Name$ createTestButton��5      $��Create New Test��6+   $
��Left=�6E   $��
10,430,0,0q�6`   $	��Top=�6t   $	��565��6�   $��49��6�   $��14(�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF3F3F3��6#   � 5      $ 	#FFEBEBEB��6#    � Offset$	 0.5Q�65   � 5      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5      $ 	#FFCDCDCD��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ 
editButton��5      $��Edit Selected Test��6%   $
��Left=�6B   $��580,430,0,0q�6]   $	��Top=�6r   $	��250��6�   ���	#FF707070${�False��6�   ��5      �� 5      $	 0,1&�6&   .��5      � $ 	#FFF3F3F3��6#   � 5      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5       $ 	#FFCDCDCD��6#   $ 1Q�65   5!      5#      �� 5$   
   -   5        $ deleteButton��5$      $��Delete Test��6'   $
��Left=�6=   $��715,457,0,0q�6X   $	��Top=�6m   $	��115��6�   ${�False��6�   ��5%      �� 5&      $	 0,1&�6&   .��5'      � $ 	#FFF3F3F3��6#   � 5(      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5)      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 5*      $ 	#FFCDCDCD��6#   $ 1Q�65   5+      5-      �� 5.   
   -   5        	 ��Name$	 infoTextBox��5.      $
��Left=�6'   $��
580,52,0,0q�6B   
 �� TextWrapping$

 Wrap=�6V   $	��Top=�6j   $	��250��6�   $	��372��6�   ���	#FF707070${�False��6�   $��<no tests selected>��6�   �� 5/   
   $��Detailed Info��6   $��
580,14,0,0q�6(   $��20(�6<   $
��Bold"�6J   $��38��6\   $	��Top=�6h   $
��Left=�6�   $	��160��6�   �� 50   
   -   5        $ viewResultButton��50      $��View Results��6+   $
��Left=�6B   $��580,457,0,0q�6]   $	��Top=�6r   $	��130��6�   ${�False��6�   ��51      �� 52      $	 0,1&�6&   .��53      � $ 	#FFF3F3F3��6#   � 54      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 55      $ 	#FFDDDDDD��6#   $	 0.9Q�65   � 56      $ 	#FFCDCDCD��6#   $ 1Q�65   57      59      �� 5:   
   $��10,51,265,65q�6   5<      5=      