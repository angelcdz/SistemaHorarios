   M S B A M L   `   `   `  ����V  RSistemaHorarios.Client.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SistemaHorarios.Client.View.Converters&SistemaHorarios.Client.View.Converters  5      =    7SistemaHorarios.Client.View.Telas.ConsultarNiveisAcesso   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      K
Converters4clr-namespace:SistemaHorarios.Client.View.Converters     5      $	��700��5      $	��400��6+     � 	Resources  5      @   :SistemaHorarios.Client.View.Converters.MultiValueConverter   MultiValueConverter>   8SistemaHorarios.Client.View.Converters.CheckBoxConverter  CheckBoxConverter��%:   &	        &	        5	   
   6)     5
   
   6'   5      .��5      � .+�5   
   �� $	��618��6   $	��Top=�6   $��
50,140,0,0q�67   $	��213��6i   $
��Left=�6v   ��6K   �� *Lista+ �� View 5      �� 5      .P�5      �� $��Código��6M    �� Width$ 80��6]    �� DisplayMemberBinding 6%   �� *Codigo+6]   �� 5      $
��Nome��6K   $	 300��6Y    6%   �� *Nome+6Y   �� 5      $��Admin��6�   $ 70��6�    6%   �� *Administrador+ �� 	Converter# [ 6�   �� 5      $��Consulta��6}   $ 70��6�    6%   �� *	Consultas+# [ 6�   �� 5      $��Operações��6}   $ 70��6�    6%   �� *	Operacoes+# [ 6�   5      5      �� 5   
   $	��Top=�6   $��Código:��6,   $
��Wrap=�6;   $��	50,64,0,0q�6O   $
��Left=�6b   �� 5   
   -   5         ��Name$ TextBoxCodigo��5      $��80��6)   $	��Top=�64    �� TextWrapping$
 Wrap=�6L   $��	50,85,0,0q�6`   $��23��6s   $
��Left=�6   �� 5   
   $	��Top=�6   $��Nome:��6,   $
��Wrap=�69   $��
135,64,0,0q�6M   $
��Left=�6a   �� 5   
   -   5        $ TextBoxNome��5      $	��260��6'   $	��Top=�63   $
 Wrap=�6K   $��
135,85,0,0q�6_   $��23��6s   $
��Left=�6   �� 5   
   $	��100��6   $	��Top=�6     DefaultButton#��[ 65   $��
568,78,0,0q�6\   $
��Left=�6p   $��Buscar��6�   ��6�   �� *ActionCommand+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� ElementName$ TextBoxCodigo��6   	 �� Path$
	 Text�6:   �� 5       $ TextBoxNome��6   $
	 Text�68   �� 5!      $ 
CheckAdmin��6   $	 	IsChecked�67   �� 5"      $ CheckConsulta��6   $	 	IsChecked�6:   �� 5#      $ CheckOp��6   $	 	IsChecked�64   5$      5&      �� 5'   
   $	��Top=�6   $
��Wrap=�6D   $��
50,358,0,0q�6X   $
��Left=�6l   ��6,   �� *Status+6l   �� 5(   
   -   5        
 ��Name$
 
CheckAdmin��5(      $��Administrador��6'   $
��Left=�6?   $��
400,68,0,0q�6Z   $	��Top=�6n   $	��105��6�   �� 5)   
   -   5        $
 CheckConsulta��5)      $��	Consultas��6*   $
��Left=�6>   $��
400,88,0,0q�6Y   $	��Top=�6m   $��87��6�   �� 5*   
   -   5        $
 CheckOp��5*      $��Operações��6$   $
��Left=�68   $��400,108,0,0q�6S   $	��Top=�6h   $	��105��6�   5+      5,      