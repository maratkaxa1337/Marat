   M S B A M L   `   `   `  ����@  <Marat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Marat.Views.PagesMarat.Views.Pages  5      *    $Marat.Views.Pages.ApplicantsViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Marat.Views.Pages     5      -   5          N� Title$  ApplicantsViewPage��5	      .��5      � 
�������.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewApplicants��5      $
��Left=�6+   $	��275��6F   $��
30,115,0,0q�6S   $	��Top=�6g   $	��740��6   �� 5   
   -   5         ��Name$ 
buttonBack��5      $��
Назад��6%   $
��Left=�65   $��	30,58,0,0q�6P   $	��Top=�6c   $	��145��6{   $��35��6�   6�   �� 5   
   -   5        $ 
buttonExit��5      $��
Выйти��6%   $
��Left=�65   $��
30,395,0,0q�6P   $	��Top=�6d   $	��145��6|   $��35��6�   6�   �� 5   
   -   5        $ buttonOpenToEdit��5      $6��0Открыть на редактирование��6+   $
��Left=�6O   $��380,395,0,0q�6j   $	��Top=�6   $	��210��6�   $��35��6�   6�   �� 5   
   -   5        $ buttonRemove��5      $��Удалить��6'   $
��Left=�69   $��625,395,0,0q�6T   $	��Top=�6i   $	��145��6�   $��35��6�   6�   �� 5   
   -   5         ��Name$ 	txtSearch��5      $
��Left=�6%   $��23��6@   $��
377,67,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��390��6�   6�   �� 5   
   $��Поиск:��6   $
��Left=�6!   $��
325,67,0,0q�6<   $	��Top=�6P   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ searchEmploymentDate��5      $
��Left=�63   $��
538,38,0,0q�6N   $	��Top=�6b   �� 5   
   $B��<Фильтровать по дате регистрации:��6   $
��Left=�6;   $��
325,38,0,0q�6V   $	��Top=�6j   �� 5   
   -	   5        $ buttonSearch��5      $��Применить��6'   $
��Left=�6;   $��
645,38,0,0q�6V   $	��Top=�6j   $	��122��6�   $��24��6�   6�   5      5      