   M S B A M L   `   `   `  ����B  >EMS_PLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EMS_PLLEMS_PLL  5   	       EMS_PLL.SearchAndUpdate   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:EMS_PLL     5   	     � Title$  SearchAndUpdate��5   	   $	��500��6!   $	��500��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ 	lbl_EmpID��5
      $��
EmployeeID��6#   $
��Left=�68   $��	18,22,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ 	lbl_eName��5      $��EmployeeName��6#   $
��Left=�6:   $��	18,57,0,0q�6U   $	��Top=�6h    J� RenderTransformOrigin$ 0.069,0.272&�6�   �� 5   
   -   5        $ lbl_eLoc��5      $��EmployeeLoc��6"   $
��Left=�68   $��	18,88,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lbl_ePh��5      $��EmployeeContact��6!   $
��Left=�6;   $��
10,122,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ lbl_Dept��5      $��EmployeeDept��6"   $
��Left=�69   $��
10,157,0,0q�6T   $	��Top=�6h   $ -0.029,0.466&�6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
125,22,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��
125,57,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $��
125,88,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5   
   -	   5        $ textBox3��5      $
��Left=�6$   $��23��6?   $��125,125,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -
   5        $ textBox4��5      $
��Left=�6$   $��23��6?   $��125,160,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ btn_add��5      $��Add Employee��6"   $
��Left=�69   $��
312,45,0,0q�6T   $	��Top=�6h   $	��170��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
85,199,0,0q�6@   $	��Top=�6T   $	��261��6l   $	��310��6y   �� 5   
   -   5        $ 	btn_reset��5      $��Reset��6$   $
��Left=�64   $��
312,88,0,0q�6O   $	��Top=�6c   $	��170��6{   �� 5   
   -   5        $ btn_display��5      $��Display��6&   $
��Left=�68   $��312,122,0,0q�6S   $	��Top=�6h   $	��170��6�   6�   5      5      