   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	       Presentacion.FormEmpleado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$  FormEmpleado��5   	   $	��300��6   $	��800��6+   .��5	      � .+�5
   
   �� $
��Dni:��6   $
��Left=�6   $��	44,15,0,0q�6:   $	��Top=�6M   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��	19,38,0,0q�6=   $	��Top=�6P   �� 5   
   $��Puesto:��6   $
��Left=�6"   $��	26,61,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ tbDni��5      $
��Left=�6!   $��	80,19,0,0q�6<    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��140��6{   �� 5   
   -   5        $ tbNombre��5      $
��Left=�6$   $��	80,42,0,0q�6?   $
 Wrap=�6R   $	��Top=�6f   $	��140��6~   �� 5   
   -   5         ��Name$ cbPuesto��5      $
��Left=�6%   $��	80,65,0,0q�6@   $	��Top=�6S   $	��140��6k   .@�5      �� $��Auxiliar��6   �� 5      $��	Asistente��6   �� 5      $��Administrador��6   5      �� 5   
   -   5         ��Name$ btnRegistrar��5      $��	Registrar��6'   $
��Left=�6;   $��
68,118,0,0q�6V   $	��Top=�6j   $	��124��6�   6�   �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $
��Left=�69   $��
68,143,0,0q�6T   $	��Top=�6h   $	��124��6�   6�   �� 5   
   -   5        $ btnOrdenarPorSueldo��5      $��Ordenar por Sueldo��6.   $
��Left=�6K   $��
68,168,0,0q�6f   $	��Top=�6z   $	��124��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��
68,193,0,0q�6N   $	��Top=�6b   $	��124��6z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEmpleados��5      $��259,19,22,20q�6(    J� RenderTransformOrigin$ 0.5,0.5&�6>   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.509Q�6$   �� 5      T� 5       T� Y$ 1.991Q�6)   5      5!      5#      5$      