   M S B A M L   `   `   `  ����V  RSistemaHorarios.Client.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SistemaHorarios.Client.View.Converters&SistemaHorarios.Client.View.Converters  5      =    7SistemaHorarios.Client.View.Telas.CadastrarNiveisAcesso   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      K
Converters4clr-namespace:SistemaHorarios.Client.View.Converters     5      $	��215��5      $	��437��6     � 	Resources  5      @   :SistemaHorarios.Client.View.Converters.MultiValueConverter   MultiValueConverter��%   &	          5   
   6)   5	      .��5
      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��81,108,76,87q�6.   .+�5      �� -   5         ��Name$ 
CheckAdmin��5      $��Administrador��6+   $��15��6C   $	��Top=�6O   $	��110��6g   �� 5      -   5        $ CheckConsultas��5      $��	Consultas��6/   $��15��6C   $	��Top=�6O   $��90��6g   �� 5      -   5        $ CheckOp��5      $��Operações��6(   $��0,0,0,5q�6<   5      �� 5   
   $
��Left=�6   $��	50,50,0,0q�6/   $
��Wrap=�6B   $��Nome do Nível:��6V   $	��Top=�6l   �� 5   
   -   5         ��Name$ TextNome��5      $
��Left=�6$   $��23��5   
   $��	50,71,0,0q�6    �� TextWrapping$
 Wrap=�6)   $	��Top=�6=   $	��350��6U   ��5   
   �� *Text+�� 5   
   $��Criar��6     DefaultButton#��[ 6!   $
��Left=�5   
   $��
50,154,0,0q�6%   $	��Top=�5   
   $	��150��6"   {�6.   �� *CriarEnabled+��5   
   �� *ActionCommandCriar+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� Path$
 Text�6    �� ElementName$ TextNome��6*   �� 5      $ 	IsChecked�6   $ 
CheckAdmin��6/   �� 5      $ 	IsChecked�6   $ CheckConsultas��6/   �� 5      $ 	IsChecked�6   $ CheckOp��6/   5      5       �� 5!   
   $��Cancelar��6   #��[ 6$   $
��Left=�5"   
   $��250,154,0,0q�6%   $	��Top=�5#   
   $	��150��6"   {�6.   �� *CancelarEnabled+��5$   
   �� *ActionCommandCancelar+�� 5%   
   $
��Left=�6   $��
50,189,0,0q�6/   $
��Wrap=�6C   $	��Top=�6o   ��6W   �� *Status+6o   5'      5(      