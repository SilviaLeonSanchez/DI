   M S B A M L   `   `   `  ����  Ejemplo_Bindings!    Ejemplo_Bindings.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   �� -   5        $��Ir a Pantalla Secundaria��5      $
��Left=�64   $��348,283,0,0q�6O   $	��Top=�6d   $	��159��6|   $��26��6�   �� 5   
   -   5         ��Name$ ComboBoxPersonas��5      $
��Left=�6Y   $��
332,46,0,0q�6t   $	��Top=�6�   $	��153��6�   ��6.   ��  �� Path$ ListaPersonas�6�   �� 5   
   $
��Left=�6=   $��67��6X   $��	10,46,0,0q�6d   $	��Top=�6w   $	��229��6�   ��6   �� $ ListaPersonas�6�   �� 5	   
   $
��Left=�6T   $��
332,73,0,0q�6o   $	��Top=�6�   $	��153��6�   $��40��6�   ��6   ��  �� ElementName$ ComboBoxPersonas��$ SelectedItem�6�   &   System.Windows.Controls.DataGrid  5
   
   $
��Left=�6      AutoGenerateColumns . $��
10,143,0,0q�6t   $	��Top=�6�   $	��119��6�   $	��229��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6.   �� $ ListaPersonas�5        5   
   $
��Left=�6    .  $��265,143,0,0q�6u   $	��Top=�6�   $	��119��6�   $	��242��6�   $ 0.5,0.5&�6�   ��6.   �� $ ListaPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ NOMBRE��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� $ Nombre�  5      $ APELLIDO��6%    67   �� $ Apellido�5      �� 5   
   -   5        $��Nueva Persona��5      $
��Left=�6)   $��212,283,0,0q�6D   $	��Top=�6Y   $	��112��6q   $��26��6}   6�   5      5      