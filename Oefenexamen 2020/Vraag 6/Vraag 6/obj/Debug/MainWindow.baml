   M S B A M L   `   `   `  ����B  >Vraag 6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Vraag_6Vraag_6  5   	       Vraag_6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Vraag_6     5   	     � Title$  
MainWindow��5   	   $	��470��6   $	��800��6)   .��5	      ]� .+�5
   
   o� -   5         o�Name$ 	Hoofdmenu��5
      $	��Top=�6#   .@�5      m� -   5         m�Name$ MnuAfsluiten��5      $��	Afsluiten��6-   6@   m� 5      -   5        $ MnuAantalBerekeningen��5      $��Aantal Berekeningen��66   .@�5      m� -   5        $ 	MnuTotaal��5      $��Totaal��6.   6>   m� 5      -   5        $ 
MnuDetails��5      $��Details��6/   6@   5      5      � 5   
   .+�5      �� $��
Kamertype:��6   $
��Left=�6)   $��	20,19,0,0q�6D   $	��Top=�6W   $	��100��6o   �� 5      $��Aantal personen:��6   $
��Left=�6/   $��	20,62,0,0q�6J   $	��Top=�6]    J� RenderTransformOrigin$ 0.208,-0.776&�6u   $	��100��6�   �� 5      $��Maaltijdregime��6   $��20,110,619,214q�6/   .��5      �� $��0,10,0,0q�6   .+�5      	� -   5         	�Name$ RadGeen��5   "   $��Geen maaltijden��63   	� 5      -   5        $ 
RadOntbijt��5   "   $��Alleen ontbijt��66   	� 5      -   5        $ RadOntbijtAvond��5   "   $��Ontbijt en Avondmaal��6;   5      5      �� 5      -	   5         ��Name$ BtnBerekenen��5      $��	Berekenen��6+   $
��Left=�6?   $��185,170,0,0q�6Z   $	��Top=�6o   $	��100��6�   $��30��6�   6�   �� 5      -
   5        $ 	BtnWissen��5      $��Wissen��6(   $
��Left=�69   $��298,170,0,0q�6T   $	��Top=�6i   $	��100��6�   $��30��6�   6�   �� 5      -   5        $��CboKamertype��5      $
��Left=�6+   $��
125,23,0,0q�6F   $	��Top=�6Z   $	��160��6r   6~   �� 5      -   5         ��Name$ TxtAantalPersonen��5      $
��Left=�61   $��23��6L   $��
125,66,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $��65��6�   6�   �� 5      -   5         ��Name$ 	ImgCanvas��5      $
��Left=�6'   $	��250��6B   $��
417,10,0,0q�6O   $	��Top=�6c   $	��350��6{   �� 5       -   5        $ TxtResultaat��5       $
��Left=�6,   $	��127��6G   $��
20,275,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��550��6�   $��Courier New)�6�   "	 �� VerticalScrollBarVisibility$
	 Auto=�6�   5#      5$      5%      