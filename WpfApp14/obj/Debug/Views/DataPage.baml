   M S B A M L   `   `   `  ����C  ?WpfApp14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp14.ViewsWpfApp14.Views  5          WpfApp14.Views.DataPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfApp14.Views     5      -   5          N� Title$  DataPage��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.8* �6   �� 5      $
��0.1* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $��Пошук: ��6   $��16(�6'   �� 5      -   5         ��Name$ textBoxFind��5   0   $	��300��6   $��16(�6"   6F   5      �� 5   
   -   5        $��20��5      $	��100��6   $
��Left=�6)   $��	20 0 0 0 q�6D   $��
Назад��6W   6g   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ UserGrid��5       $��1��6      AutoGenerateColumns .  $	��285��6N   $	��Top=�6[      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *Id+  5       $ 
Логін��6%   $ * 64   	 6>   �� *Login+  5!      $ Пароль��6%   $ * 65   	 6?   �� *
Password+  5"      $ Роль��6%   $ * 63   	 6=   �� *Roles.Names+5$      �� 5%   
   -   5        $��Видалити��5%      $��350,8,350,0q�6=   $��2��6R   $��20��6_   $	��Top=�6k   �� 5&   
   -   5        $)��#Додати коритсувача��5&      $��
20,8,641,0q�6.   $��2��6B   $��20��6O   $	��Top=�6[   6s   �� 5'   
   -   5        $��Редагувати��5'      $
��Left=�6&   $��	675,8,0,0q�6A   $��2��6T   $	��Top=�6a   
 J� RenderTransformOrigin$
 -0.463,0.017&�6y   $��91��6�   6�   �� 5(   
   $��Логін:��6   $
��Left=�6!   $��
18,292,0,0q�6<   $��1��6P   $	��Top=�6]   $
 0.132,-0.039&�6u   �� 5)   
   -   5        $ textEditLogin��5)      $
��Left=�6)   $��
60,296,0,0q�6D   $��1��6X    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5*   
   $��Пароль:��6   $
��Left=�6"   $��185,292,0,0q�6=   $��1��6R   $	��Top=�6_   �� 5+   
   -	   5        $ textEditPassword��5+      $
��Left=�6,   $��244,296,0,0q�6G   $��1��6\   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   �� 5,   
   $��	Роль:��6   $
��Left=�6    $��369,292,0,0q�6;   $��1��6P   $	��Top=�6]   �� 5-   
   -
   5         ��Name$ comboBoxEditRole��5-      $��413,294,255,0q�6-   $��1��6D    �� DisplayMemberPath$ Names��6o    �� SelectedValuePath$ Id��6�   $��22��6�   $	��Top=�6�   ��6Q   �� *Roles+ �� SelectedValue 6�   �� *
SelectRole+6�   5.      5/      