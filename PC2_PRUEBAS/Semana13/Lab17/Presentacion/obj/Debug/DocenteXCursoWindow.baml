   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	   &     Presentacion.DocenteXCursoWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	     � Title$  DocenteXCursoWindow��5   	   $	��450��6%   $	��800��62   .��5	      � .+�5
   
   �� $��Docente:��6   $
��Left=�6#   $��	18,14,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Curso:��6   $
��Left=�6!   $��	32,40,0,0q�6<   $	��Top=�6O   �� 5   
   $��	Semestre:��6   $
��Left=�6$   $��	14,65,0,0q�6?   $	��Top=�6R   �� 5   
   -   5         ��Name$ 
tbSemestre��5      $
��Left=�6&   $��	80,70,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��188��6�   �� 5   
   -   5         ��Name$ 
btnAsignar��5      $��Asignar��6%   $
��Left=�67   $��
74,154,0,0q�6R   $	��Top=�6f   $	��171��6~   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��
74,179,0,0q�6N   $	��Top=�6b   $	��170��6z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgDocenteXCursos��5      $��339,19,22,20q�6-    J� RenderTransformOrigin$ 0.5,0.5&�6C   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.509Q�6$   �� 5      T� 5       T� Y$ 1.991Q�6)   5      5      �� 5   
   -   5         ��Name$ 
cbDocentes��5      $
��Left=�6'   $��	80,16,0,0q�6B   $	��Top=�6U   $	��188��6m   �� 5   
   -   5        $ cbCursos��5      $
��Left=�6%   $��	80,43,0,0q�6@   $	��Top=�6S   $	��188��6k   5      5      