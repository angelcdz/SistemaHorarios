   M S B A M L   `   `   `  ����V  RSistemaHorarios.Client.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:SistemaHorarios.Client.View.Converters&SistemaHorarios.Client.View.Converters  5   	   '    !SistemaHorarios.Client.View.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   K
Converters4clr-namespace:SistemaHorarios.Client.View.Converters     5   	     � WindowState$  Normal=�5   	    � Title$ Login��5   	   $	��258��6   $	��420��6$    � WindowStartupLocation$ CenterScreen=�60    � 	Resources 5      @   :SistemaHorarios.Client.View.Converters.MultiValueConverter   MultiValueConverter��%   &	          5   
   6)   5	      .��5
      � .+�5   
   �� -   5         ��Name$
 Flag��5      $y�Hidden=�6    ��64   �� *Flag+6J   �� 5   
   $
��Left=�6   $��	50,35,0,0q�6/   $
��Wrap=�6B   $��Login��6V   $	��Top=�6c   �� 5   
   $
��Left=�6   $��	50,88,0,0q�6/   $
��Wrap=�6B   $��Senha��6V   $	��Top=�6c   �� 5   
   -   5        $ 	TextLogin��5      $��23��6%   $��
50,60,50,0q�61    �� TextWrapping$
 Wrap=�6E   $	��Top=�6Y   G� 5   
   -   5         G�Name$ TextPass��5      $��23��6(   $��50,109,50,0q�64   $	��Top=�6I   �� 5   
   $��Login��6   $
��Left=�6!   $��
50,154,0,0q�6<   $	��Top=�5        DefaultButton#��[ 6)   ��5      �� *ActionCommandLogin+{�5      �� *LoginEnabled+��5      `� 5       `� 	Converter# [  6   .1�5      ��  �� ElementName$ 	TextLogin��6   	 �� Path$
	 Text�66   �� 5      $ TextPass��6   5      5      �� 5   
   $��Cancelar��6   $��
0,154,50,0q�6$   $	��Top=�68   $��Right=�5      #��[ 6.   ��5      �� *ActionCommandCancelar+�� 5   
   $
��Left=�6   $��
50,189,0,0q�6/   $
��Wrap=�6C   $	��Top=�6o   ��6W   �� *Status+6o   5      5       