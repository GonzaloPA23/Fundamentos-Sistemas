   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	   ,    &Presentacion.DocenteXUniversidadWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$*  $Asignación de Docente a Universidad��5   	   $	��450��65   $	��800��6B   .��5	      � .+�5
   
   �� ���	#FF2C3E50 �� CornerRadius$ 8��6(   $��10q�69   ._�5      �� .+�5      �� $*��$Asignación de Docente a Universidad��6   $��Center=�6F   
�������$
��Bold"�6v   $��16(�6�   $��	0,10,0,20q�6�   �� 5      $��20q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Docente:��6    $
��Left=�63   $��Center=�6N   
�������6i   �� 5      -   5         ��Name$ 
cmbDocente��5   #   $
��Left=�67   $��Center=�6R   $	��150��6m   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Universidad:��6    $
��Left=�67   $��Center=�6R   
�������6m   �� 5      -   5        $ cmbUniversidad��5   #   $
��Left=�6;   $��Center=�6V   $	��150��6q   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Detalle:��6    $
��Left=�63   $��Center=�6N   
�������6i   �� 5      -   5         ��Name$ 
txbDetalle��5   "   $
��Left=�66   $��Center=�6Q   $	��200��6l   $��65��6x   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� -   5         ��Name$ 
btnAgregar��5   !   $��Asignar��65   $	��100��6G   ���	#FF2ECC71
�������6}   �� 5       -   5        $ btnSalir��5    !   $��Salir��63   $	��100��6C   $��10,0,0,0q�6O   ���	#FFBDC3C7
�������6�   5!      5"      5#      5$      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dgvDocenteXUniversidades��5&      $
��Left=�65   $	��262��6P   $��
292,60,0,0q�6]   $	��Top=�6q   $	��469��6�   5'      5(      