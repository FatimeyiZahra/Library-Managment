   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   +    %Library_Managment.Windows.AddCustomer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � WindowStartupLocation$  CenterScreen=�5	   	   $��Segoe UI Emoji)�5
   
    � 
ResizeMode$ NoResize=�5   	    � Title$ AddCustomer��5   	   $	��550��6   $
��1057��6+   .��5      � .+�5   
   � $��10,10,817,-57q�6   .+�5      �� $	��Top=�6   $��15q�61   .+�5      �� -   5         ��Name$ TxtCusername��5      $
��0,10q�60   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Adi��6>    %  !MaterialDesignFloatingHintTextBox#��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ TxtCsurname��5      $
��0,10q�6/   $ Soy Adi��6=   #��[  6f   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 	TxtCphone��5      $
��0,10q�6-   $ Tel-No��6;   #��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 	TxtCemail��5      $
��0,10q�6-   $ E-poct��6;   #��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ TxtCcode��5      $ Musteri Kodu��6,   #��[  6Z   $��Champagne & Limousines)�6�   $��18(�6�   5      �� 5      -   5         ��Name$ addCustomers��5      $��
TƏSDIQLƏ��6+   $��40,348,40,151q�6>   6U   �� 5      -   5        $ editCustomer��5      $��DƏYİŞ��6+   $��40,350,40,110q�6;   $y�Hidden=�6R   6f   �� 5      -   5        $ deleteCustomer��5      $	��SIL��6-   $��40,387,40,73q�6;   $y�Hidden=�6R   6f   5      &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ grdCustomer��5      $��323,0,10,10q�6(      AutoGenerateColumns$ False��6=      CanUserAddRows$ False��6Y   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.10* 6%      Header$ ID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $
 0.20* 6%   $ Ad��63    6?   �� *CustomerName+  5      $
 0.20* 6%   $ Soyad��63    6B   �� *CustomerSurname+  5       $
 0.20* 6%   $ Tel-no��63    6C   �� *CustomerTelNo+  5!      $
 0.20* 6%   $ Epoct��63    6B   �� *CustomerEmail+  5"      $
 0.20* 6%   $ Musteri Kodu��63    6I   �� *CustomerCode+5%      5&      5'      