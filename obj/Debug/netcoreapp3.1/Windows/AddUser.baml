   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   '    !Library_Managment.Windows.AddUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$  AddUser��5   	   $	��400��6   $	��550��6&    � WindowStartupLocation$ CenterScreen=�5
   	   $��Segoe UI Emoji)�5   
    � 
ResizeMode$ NoResize=�5   	   .��5      � $��	0,0,0,-16q�6   .+�5   
   � -   5         �Name$ 
grdAddUser��5      $��319,-2,0,-280q�6$   $y�Hidden=�6<   .+�5      �� $	��Top=�6   $��15q�61   .+�5      �� -   5         ��Name$ TxtUserName��5      $
��0,10q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Adi��6=    %  !MaterialDesignFloatingHintTextBox#��[  6b   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ TxtUserPassword��5      $
��0,10q�63   $ Sifre��6A   #��[  6h   $��Champagne & Limousines)�6�   $��18(�6�   5      �� 5      -   5         ��Name$ 
addUserBtn��5      $��
TƏSDIQLƏ��6)   $��40,176,40,359q�6<   6S   �� 5      -   5        $ editUser��5      $��DƏYİŞ��6'   $��40,213,40,322q�67   $y�Hidden=�6N   6b   �� 5      -   5        $ 
deleteUser��5      $	��SIL��6)   $��40,252,40,283q�67   $y�Hidden=�6g   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdUser��5      $��10,-2,231,32q�6$      AutoGenerateColumns$ False��6:   	   CanUserAddRows$	 False��6V   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ ID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $ 0.20* 6%   $ Ad��63    6?   �� *
Username+  5      $ 0.20* 6%   $ Sifre��63    6B   �� *
Password+5       �� 5!   
   -   5        $ addUser��5!      $��ƏLAVƏ ET ��6"   $
��Left=�66   $��434,336,0,0q�6Q   $	��Top=�6f   6~   5"      5#      