   M S B A M L   `   `   `  ����V  RSistemaHorarios.Client.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SistemaHorarios.Client.View.Converters&SistemaHorarios.Client.View.Converters  5      6    0SistemaHorarios.Client.View.Telas.CadastrarCurso   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      K
Converters4clr-namespace:SistemaHorarios.Client.View.Converters     5      $	��215��5      $	��437��6,     � 	Resources  5      @   :SistemaHorarios.Client.View.Converters.MultiValueConverter   MultiValueConverter��%   &	          5	   
   6)   5
      .��5      � .+�5   
   �� $
��Left=�6   $��	50,50,0,0q�6/   $
��Wrap=�6B   $��Nome do Curso:��6V   $	��Top=�6l   �� 5   
   -   5         ��Name$ TextNome��5      $
��Left=�6$   $��23��5      $��	50,71,0,0q�6    �� TextWrapping$
 Wrap=�6&   $	��Top=�6:   $	��350��6R   ��5      �� *Text+�� 5   
   $��Criar��6     DefaultButton#��[ 6!   $
��Left=�5      $��
50,154,0,0q�6"   $	��Top=�5      $	��150��6   {�6+   �� *CriarEnabled+��5      �� *ActionCommandCriar+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� Path$
 Text�6    �� ElementName$ TextNome��6*   �� 5      $ SelectedItem�6   $ Combo��62   5      5      �� 5   
   $��Cancelar��6   #��[ 6$   $
��Left=�5      $��250,154,0,0q�6"   $	��Top=�5      $	��150��6   {�6+   �� *CancelarEnabled+��5      �� *ActionCommandCancelar+�� 5   
   $
��Left=�6   $��
50,189,0,0q�6/   $
��Wrap=�6C   $	��Top=�6o   ��6W   �� *Status+6o   �� 5    
   $
��Left=�6   $��	50,99,0,0q�6/   $
��Wrap=�6B   $��	Período:��6V   $	��Top=�6f   �� 5!   
   -   5         ��Name$ Combo��5!      $
��Left=�6"   $��
50,120,0,0q�6=   $	��Top=�6Q   $	��350��6i    �� DisplayMemberPath$
 Nome��5"   1   ��6   �� *Lista+5$      5%      5&      