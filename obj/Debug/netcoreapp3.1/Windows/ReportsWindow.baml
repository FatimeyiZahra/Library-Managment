   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   -    'Library_Managment.Windows.ReportsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  ReportsWindow��5   	   $	��650��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Emoji)�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��90* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ txtStartDate��5   B   $
��Left=�6   $��20,0,0,0q�60   $��Center=�6X   $	��150��6s   $��24��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Baslangic tarix��6�      MaterialDesignDatePicker#��[  6�   $��Champagne & Limousines)�6�   $��14(�6    5   
   -   5        $ 
txtEndDate��5   D   $
��Left=�6   $��	200,0,0,0q�61   $��Center=�6X   $	��150��6s   $��24��6   $ Bitme tarixi��6�   #��[  6�   $��Champagne & Limousines)�6�   $��14(�6  �� 5   
   -   5         ��Name$ 	btnSearch��5      $��
Axtaris Et��6$   $��Right=�69   $��Center=�6U   $��0,0,40,0q�6p   $��30��6�   $	��134��6�   $��12(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ reportDataGrid��5   5   $��
10,0,10,10q�6   $��1��6(      AutoGenerateColumns$ False��6N   	   CanUserAddRows$	 False��6j   
   
IsReadOnly$

 True��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.05* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	IssueId+  5      $ 0.05* 6%   $ Ad��63    6?   �� *CustomerName+  5      $ 0.10* 6%   $ Soyad��63    6B   �� *CustomerSurname+  5      $ 0.10* 6%   $	 Tel��63    6@   �� *CustomerTel+  5      $ 0.10* 6%   $ Kitab Ad��63    6E   �� *
BookName+  5      $ 0.10* 6%   $ 
Kitab Yaz.��63    6G   �� *
BookAuthor+  5      $ 0.10* 6%   $ Kitab Barkod��63    6I   �� *Bookbarcode+  5      $ 0.10* 6%   $
 Novu��63    6A   �� *CategoryName+  5      $ 0.10* 6%   $ Cerime Miqdari��63    6K   �� *
TotalPrice+5!      5$      5%      