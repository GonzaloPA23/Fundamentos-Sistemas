   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	        Presentacion.DocenteWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$  Gestión de Docentes��5   	   $��502.5��6%   $	��800��64   .��5	      � .+�5
   
   �� ���	#FF2C3E50 �� CornerRadius$ 8��6(   $��10q�69   ._�5      �� .+�5      �� $��Gestión de Docentes��6   $��Center=�66   
�������$
��Bold"�6f   $��16(�6x   $��	0,10,0,20q�6�   �� 5      $��20q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Nombre:��6    $
��Left=�62   $��Center=�6M   
�������6h   �� 5      -   5         ��Name$ tbNombre��5   "   $
��Left=�64   $��Center=�6O   $	��150��6j   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��	Apellido:��6    $
��Left=�64   $��Center=�6O   
�������6j   �� 5      -   5        $ 
tbApellido��5   "   $
��Left=�66   $��Center=�6Q   $	��150��6l   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� $��Escuela:��6    $
��Left=�63   $��Center=�6N   
�������6i   �� 5      -   5        $ 	tbEscuela��5   "   $
��Left=�65   $��Center=�6P   $	��150��6k   5      �� 5      $ 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5      �� -   5         ��Name$ btnRegistrar��5   !   $��	Registrar��67   $	��100��6K   ���	#FF3498DB
�������6�   �� 5       -   5        $ btnModificar��5    !   $��	Modificar��67   $	��100��6K   $��10,0,0,0q�6W   ���	#FF2ECC71
�������6�   �� 5!      -   5        $ btnEliminar��5!   !   $��Eliminar��66   $	��100��6I   $��10,0,0,0q�6U   ���	#FFE74C3C
�������6�   �� 5"      -   5        $ btnBuscarPorEscuela��5"   !   $��Buscar por Escuela��6>   $	��150��6[   $��10,0,0,0q�6g   ���	#FF9B59B6
�������6�   �� 5#      -   5        $ btnSalir��5#   !   $��Salir��63   $	��100��6C   $��10,0,0,0q�6O   ���	#FFBDC3C7
�������6�   5$      5%      5&      5'      &   System.Windows.Controls.DataGrid  5)   
   -	   5          Name$ 
dgDocentes��5)      $��66,246,94,34q�6'   6=   5*      5+      