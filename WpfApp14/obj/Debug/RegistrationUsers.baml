   M S B A M L   `   `   `  ����C  ?WpfApp14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp14WpfApp14  5   	        WpfApp14.RegistrationUsers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp14     5   	     � Title$1  +Реєстрація користувача��5   	   $	��178��6(   $	��494��65    � WindowStartupLocation$ CenterScreen=�6A    � Icon$$ /Picture/addusergroup_1251.ico��6f   .��5	      � $	��175��6   $	��Top=�6   
������� � ColumnDefinitions 5
   
   �� 5      $
��183* �6   �� 5      $
��311* �6   .+�5   
   �� $��Логін:��6   $
��Left=�6!   $��	61,21,0,0q�6<   $	��Top=�6O   �� 5   
   -   5         ��Name$ login��5   �   $
��Left=�6   $��
108,25,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $	��327��6u   $��2��6�   �� 5   
   $��Пароль:��6   $
��Left=�6"   $��	49,47,0,0q�6=   $	��Top=�6P   �� 5   
   -   5        $ 	password2��5   �   $
��Left=�6   $��
108,51,0,0q�6-   $
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $	��327��6u   $��2��6�   �� 5   
   $��	Роль:��6   $
��Left=�6    $��64,0,0,0q�6;   $��Center=�6M   �� 5   
   -   5         ��Name$ comboboxRole��5   h   $
��Left=�6   $��	108,0,0,0q�6.   $��Center=�6A   $	��327��6\    �� DisplayMemberPath$ Names��6�    �� SelectedValuePath$ Id��6�   $��2��6�   ��6~   �� *Roles+	 �� SelectedValue	 6�   �� *
SelectRole+6�   �� 5   
   -   5        
 ��Name$
 buttonRegister��5   {   $ ��Зареєструвати��6   $
��Left=�6)   $��	5,110,0,0q�6D   $	��Top=�6W   $	��118��6o   $��1��6�   5      5      