   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	   $    Presentacion.UniversidadWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$  Gestión de Universidades��5   	   $	��450��6*   $	��800��67   .��5	      � .+�5
   
   �� ���	#FF2C3E50 �� CornerRadius$ 8��6(   $��10q�69   ._�5      �� .+�5      �� $��Registro de Universidades��6   $��Center=�6<   
�������$
��Bold"�6l   $��16(�6~   $��	0,10,0,20q�6�   �� 5      $��20q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Nombre:��6    $
��Left=�62   $��Center=�6M   
�������6h   �� 5      -   5         ��Name$ 	txbNombre��5   "   $
��Left=�65   $��Center=�6P   $	��150��6k   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $
��RUC:��6    $
��Left=�6/   $��Center=�6J   
�������6e   �� 5      -   5        $ txbRuc��5   "   $
��Left=�62   $��Center=�6M   $	��120��6h   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� -   5         ��Name$ btnRegistrar��5   !   $��	Registrar��67   $	��100��6K   $��0,0,10,0q�6W   ���	#FF3498DB
�������6�   �� 5      -   5        $ btnModificar��5   !   $��	Modificar��67   $	��100��6K   $��0,0,10,0q�6W   ���	#FF2ECC71
�������6�   �� 5      -   5        $ btnEliminar��5   !   $��Eliminar��66   $	��100��6I   $��0,0,10,0q�6U   ���	#FFE74C3C
�������6�   5      5      5      5       &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ dgvUniversidades��5"      $
��Left=�6-   $	��154��6H   $��
36,208,0,0q�6U   $	��Top=�6i   $	��712��6�   6�   �� 5$   
   -   5        $ btnSalir��5$      $��Salir��6#   $
��Left=�63   $	��Top=�6N   $	��100��6f   $��10,0,0,0q�6r   ���	#FFBDC3C7
�������6�   5%      5&      