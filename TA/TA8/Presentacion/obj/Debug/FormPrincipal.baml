   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	        Presentacion.FormPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$  FormPrincipal��5   	   $	��500��6   $	��852��6,   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��	0,0,0,-16q�6+    � ColumnDefinitions 5
   
   �� 5      $
��248* �6   �� 5      $
��117* �6   �� 5      $
��487* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FFFFF5F5��6    � Offset$ 1Q�61   � 5      $ 	#FF7BB7AC��6   $ 0Q�61   5      .+�5   
   �� $	��DNI��6   $
��Left=�6   $��	20,78,0,0q�69   $	��Top=�6L   $��14(�6d   $��29��6r   $��34��6~   �� 5   
   -   5         ��Name$ txtDni��5      $
��Left=�6"   $��	87,84,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��151��6�   $��22��6�   �� 5   
   $��Nombre 
Completo��6   $
��Left=�64   $��
16,107,0,0q�6O   $	��Top=�6c   $��14(�6{   $��47��6�   $��71��6�   �� 5   
   -   5        $ txtNombreCompleto��5      $
��Left=�6-   $��
87,121,0,0q�6H   $
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��151��6�   $��23��6�   �� 5   
   $��Celular��6   $
��Left=�6"   $��
16,155,0,0q�6=   $	��Top=�6Q   $��14(�6i   $��29��6w   $��53��6�   �� 5   
   -   5        $ 
txtCelular��5      $
��Left=�6&   $��
87,155,0,0q�6A   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��151��6�   $��24��6�   �� 5   
   $��Correo��6   $
��Left=�6!   $��
16,191,0,0q�6<   $	��Top=�6P   $��14(�6h   $��29��6v   $��52��6�   �� 5   
   -   5        $ 	txtCorreo��5      $
��Left=�6%   $��
87,194,0,0q�6@   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��151��6�   $��23��6�   �� 5   
   $��Registro de Choferes��6   $��Center=�6/   $��0,26,0,0q�6L   $	��Top=�6^   $��14(�6v   $
��Bold"�6�   $��29��6�   $	��146��6�   �� 5   
   -   5        	 ��Name$	 btnRegistrar��5      $��	Registrar��6'   $��Center=�6;   $��	0,254,0,0q�6X   $	��Top=�6k   $��22��6�   $	��104��6�   ���	#FFD8FFAF6�   �� 5    
   -   5        $	 btnEliminar��5       $��Eliminar��6&   $��Center=�69   $��	0,293,0,0q�6V   $	��Top=�6i   $��22��6�   $	��104��6�   ���	#FFD8FFAF6�   �� 5!   
   -   5        $	 	btnEditar��5!      $��Editar��6$   $��Center=�65   $��	0,332,0,0q�6R   $	��Top=�6e   $��22��6}   $	��104��6�   ���	#FFD8FFAF6�   �� 5"   
   -   5        $	 btnSalir��5"      $��Salir��6#   $��Center=�63   $��	0,373,0,0q�6P   $	��Top=�6c   $��22��6{   $	��104��6�   ���	#FFD8FFAF6�   &   System.Windows.Controls.DataGrid  5#   
   -	   5        
  Name$
 dtgChoferes��5#      $��1��6(   $��13,26,24,45q�68   $��2��6M   ���	#FFFDFEFF6y   (  "System.Windows.Controls.DatePicker  5$   
   -
   5          Name$ datepicker1��5$      $��Center=�6*   $��	0,420,0,0q�6G   $	��Top=�6Z   5%      5&      