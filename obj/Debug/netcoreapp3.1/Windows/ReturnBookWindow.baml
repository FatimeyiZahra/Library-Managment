   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   0    *Library_Managment.Windows.ReturnBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$  ReturnBookWindow��5   	   $	��750��6"   $
��1000��6/    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Emoji)�5   
    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��320 �6   �� 5      $	��430 �6    � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $	��500 �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ txtIssueCustomerName��5      $��40,102,41,0q�65    �� TextWrapping$
 Wrap=�6J   $	��Top=�6^   $	��160��6v   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Adi��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerCode��5      $��
40,53,41,0q�64   $
 Wrap=�6H   $	��Top=�6\   $	��160��6t   $ Musteri Kodu��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6   �� 5      -   5        $ txtIssueCustomerSurname��5      $��40,151,41,0q�67   $
 Wrap=�6L   $	��Top=�6`   $	��160��6x   $ Soy Adi��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerTel��5      $��40,199,41,0q�63   $
 Wrap=�6H   $	��Top=�6\   $	��160��6t   $ Tel-No��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerEmail��5      $��40,248,41,0q�65   $
 Wrap=�6J   $	��Top=�6^   $	��160��6v   $ E-poct��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerId��5      $��
40,10,41,0q�62   $
 Wrap=�6F   $	��Top=�6Z   $	��160��6r   $ Musteri Id-si��6   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  6+  5      � 5   
   $��1��6   .+�5      �� -   5        $ txtBookPrice��5      $��44,199,44,0q�6,   $
 Wrap=�6A   $	��Top=�6U   $	��160��6m   $ Qiymeti��6z   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5       -   5        $ txtBookName��5       $��44,150,44,0q�6+   $
 Wrap=�6@   $	��Top=�6T   $	��160��6l   $ 	Kitab Adi��6y   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5!      -	   5        $ txtBookBarcode��5!      $��
44,52,44,0q�6.   $
 Wrap=�6B   $	��Top=�6V   $	��160��6n   $ Kitab Barkod��6{   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5"      -
   5        $ txtBookAuthor��5"      $��44,101,44,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��160��6n   $ Yazici��6{   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5#      -   5        $ 	txtBookId��5#      $��
44,10,44,0q�6)   $
 Wrap=�6=   $	��Top=�6Q   $	��160��6i   $ Kitab Id-si��6v   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  6   �� 5$      -   5         ��Name$ searchByCustomerId��5$      $��
Axtaris Et��61   $
��Left=�6F   $��Bottom=�6a   $��
100,0,0,10q�6|   $��32��6�   $	��134��6�   6�   �� 5%      -   5        $ removeCustomerIssue��5%      ${�False��62   $��Kitabi qaytardi��6D   $��Right=�6^   $��Bottom=�6z   $��
0,0,100,10q�6�   $��32��6�   $	��134��6�   6�   5&      &   System.Windows.Controls.DataGrid  5'   
   -   5        	  Name$	 returnBookDataGrid��5'      $��1��6/   $��2��6<     MaterialDesignDataGrid#��[ 6P   $��0,10,0,0q�6�      MaterialDesignChipBackground#���  6�   
   AutoGenerateColumns$
 False��6�      CanUserAddRows$ False��6�      
IsReadOnly$
 True��6     Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.18* 6%      Header$ 
Sifaris Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *	OrderId+  5*      $ 0.18* 6%   $ 
Musteri Id��63    6G   �� *
CustomerId+  5+      $ 0.11* 6%   $ Kitab Id��63    6E   �� *	BooksId+  5,      $ 0.17* 6%   $ Qaytarilma Tarixi��63    6N   �� *
ReturnDate+  5-      $ 0.18* 6%   $ Cerime Miqdari��63    6K   �� *
TotalPrice+  5.      $ 0.18* 6%   $ Sifarisin Statusu��63    6N   �� *
StatusType+5  /MaterialDesignThemes.Wpf.DataGridComboBoxColumn  5/      51      52      53      