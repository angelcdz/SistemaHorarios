   M S B A M L   `   `   `  ����V  RSistemaHorarios.Client.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SistemaHorarios.Client.View.Converters&SistemaHorarios.Client.View.Converters  5      7    1SistemaHorarios.Client.View.Telas.ConsultarCursos   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      K
Converters4clr-namespace:SistemaHorarios.Client.View.Converters     5      $	��700��5      $	��400��6+     � 	Resources  5      @   :SistemaHorarios.Client.View.Converters.MultiValueConverter   MultiValueConverter��%   &	          5	   
   6)   5
      .��5      � .+�5   
   �� $
��Left=�6   $	��213��6.   $��
50,140,0,0q�6;   $	��Top=�6O   $	��618��6g   ��6s   �� *Lista+ �� View 5      �� 5      .P�5      �� $��Código��6%    �� Width$ 80��65    �� DisplayMemberBinding 6@   �� *Codigo+�� 5      $
��Nome��6%   $	 300��64    6@   �� *Nome+�� 5      $��Periodo��6%   $	 200��67    6C   �� *Periodo.NomePeriodo+5      5      �� 5   
   $
��Left=�6   $��	50,64,0,0q�6/   $
��Wrap=�6B   $��Código:��6V   $	��Top=�6e   �� 5   
   -   5         ��Name$ TextBoxCodigo��5      $
��Left=�6)   $��23��6D   $��	50,85,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $��80��6�   �� 5   
   $
��Left=�6   $��
135,64,0,0q�6/   $
��Wrap=�6C   $��Nome:��6W   $	��Top=�6d   �� 5   
   -   5        $ TextBoxNome��5      $
��Left=�6'   $��23��6B   $��
135,85,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��250��6�   �� 5   
     DefaultButton#��[ 6   $��Buscar��5      $
��Left=�6   $��
568,77,0,0q�60   $	��Top=�6D   $	��100��6\   ��5   8   �� *ActionCommand+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� Path$
 Text�6    �� ElementName$ TextBoxCodigo��6*   �� 5      $
 Text�6   $ TextBoxNome��6*   �� 5      $ SelectedItem�6   $ ComboPeriodo��62   5       5"      �� 5#   
   $
��Left=�6   $��
50,358,0,0q�6/   $
��Wrap=�6C   $	��Top=�6o   ��6W   �� *Status+6o   �� 5$   
   $
��Left=�6   $��
390,67,0,0q�6/   $
��Wrap=�6C   $��	Período:��6W   $	��Top=�6g   �� 5%   
   -   5        $��ComboPeriodo��5%      $
��Left=�6'   $��
390,85,0,0q�6B   $	��Top=�6V   $	��164��6n   	 �� DisplayMemberPath$
	 Nome��5&   4   $��23��6M   ��6   �� *
Periodos+6M   5(      5)      