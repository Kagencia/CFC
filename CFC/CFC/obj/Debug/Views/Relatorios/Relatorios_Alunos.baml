   M S B A M L   `   `   `  ����  CFC,    &CFC.Views.Relatorios.Relatorios_Alunos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Relatorios_Alunos��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $	��350 �6   �� 5	      $��90 �6   �� 5
      $��90 �6   �� 5      $��90 �6    � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      $��40 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dg_relatorio_alunos��5      $��0 0 0 20q�6�   $��6��6�   ��6b   ��  �� Path$ Alunos�6�   �� 5   
   $��	Pesquisar��6   $��1��6%   $��1��65   $��	0,0,20,10q�6B   $��Right=�6U   $��75��6q   �� 5   
   -   5         ��Name$ 
btn_Salvar��5   "   $��Salvar��6   $��2��66   $��1��6F   $��0 0 0 10q�6S   $
��Left=�6e   $��75��6�   6�   �� 5   
   -   5        $ btn_Alterar��5   #   $��Alterar��6   $��3��68   $��1��6H   $��0 0 0 10q�6U   $
��Left=�6g   $��75��6�   6�   �� 5   
   $��Cancelar��6    �� IsCancel . $��4��64   $��1��6D   $��0 0 0 10q�6Q   $
��Left=�6c   $��75��6~   �� 5   
   $��1��6   $��Right=�6"   $��30��6>   $��
0,0,110,10q�6J   $��1��6^    �� TextWrapping$
 Wrap=�6k   $�� ��6   $	��Top=�6�   $	��220��6�   5      5      