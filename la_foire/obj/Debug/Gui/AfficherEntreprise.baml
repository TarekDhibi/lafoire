   M S B A M L   `   `   `  ����  la_foire%    la_foire.Gui.AfficherEntreprise   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Liste des entreprises��5   	   $	��880��6'   $
��1150��64    � Icon$ ../Img/hist.png��6B   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��1* �6    �� 5	      $
��Auto �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridEntreprise��5         EnableRowVirtualization .  
����������#82c4c8   AutoGenerateColumns .     CanUserAddRows .  $��0,0,0.333,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *ID+6L     5      $	 Nom��6)   $	 5* 6N   
 66   �� *NOM+6N     5      $ 
Catégorie��6)   $	 5* 6T   
 6<   �� *CAT+6T     5      $ Sous catégorie��6)   $	 5* 6Z   
 6A   �� *SCAT+6Z     5      $ 
Governorat��6)   $	 4* 6\   
 6=   �� *
GOVERNORAT+6\     5      $ 
Delegation��6)   $	 4* 6\   
 6=   �� *
DELEGATION+6\     5      $
 Etat��6)   $	 6* 6P   
 67   �� *ETAT+6P     5      $ Localite��6)   $	 1* 6X   
 6;   �� *
LOCALITE+6X     5      $ Nom gérant��6)   $
	 1.5* 6V   
 6=   �� *NOMG+6V     5      $ Prénom gérant��6)   $
	 1.5* 6\   
 6@   �� *	PRENOMG+6\     5      $ Adresse��6)   $
	 1.5* 6V   
 6:   �� *	ADRESSE+6V     5      $ Tél gérant 1��6)   $
	 1.5* 6Y   
 6?   �� *TELG1+6Y     5      $ Tél gérant 2��6)   $
	 1.5* 6Y   
 6?   �� *TELG2+6Y     5      $ Tél gérant 3��6)   $	 1* 6Y   
 6?   �� *TELG3+6Y     5      $ Tél entreprise 1��6)   $
	 1.5* 6^   
 6C   �� *TELEN1+6^     5      $ Tél entreprise 2��6)   $
	 1.5* 6^   
 6C   �� *TELEN2+6^     5      $ Tél entreprise 3��6)   $
	 1.5* 6^   
 6C   �� *TELEN3+6^     5      $ Mail gérant 1��6)   $
	 1.5* 6[   
 6@   �� *MAILG1+6[     5      $ Mail gérant 2��6)   $
	 1.5* 6[   
 6@   �� *MAILG2+6[     5       $ Mail gérant 3��6)   $	 1* 6[   
 6@   �� *MAILG3+6[     5!      $ Mail entreprise 1��6)   $
	 1.5* 6`   
 6D   �� *	MAILEN1+6`     5"      $ Mail entreprise 2��6)   $
	 1.5* 6`   
 6D   �� *	MAILEN2+6`     5#      $ Mail entreprise 3��6)   $
	 1.5* 6`   
 6D   �� *	MAILEN3+6`     5$      $ Source��6)   $
	 1.5* 6T   
 69   �� *SOURCE+6T     5%      $	 Web��6)   $
	 1.5* 6N   
 66   �� *WEB+6N      RowStyle 5*      �� 5+       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5,      �� 5-       �� Binding 6*   �� *ETAT+ �� Value Jamais contactée6C   .a�5.   "   ��  �� Property � �� �� Value
 �����6?   5/      �� 50       6*   �� *ETAT+ Inscrite6C   .a�51   "   ��  � �� �#29ff1e6?   52      �� 53       6*   �� *ETAT+ Rappels en cours6C   .a�54   "   ��  � �� �#ffb3016?   55      �� 56       6*   �� *ETAT+ Rappels terminés6C   .a�57   "   ��  � �� �#a9a3b36?   58      5:      5=      � 5>      $��2��6   .+�5?      9�  9� 
IsExpanded .  $��Filtres��6.   .��5@      �  � ColumnDefinitions 5A      �� 5B      $��1* �6/   �� 5C      $��1* �6/   .+�5E      �� -   5         ��Name$ 	CBFiltres��5E   #   $��0��66    �� SelectedIndex$ 0��6F   
�������.@�5F      �� $	��Nom��6+   �� 5G      $��
Catégorie��6+   �� 5H      $��Sous Catégorie��6+   �� 5I      $��Grouvernorat��6+   �� 5J      $��
Delegation��6+   �� 5K      $��	Localité��6+   �� 5L      $
��Etat��6+   �� 5M      $��Nom gérant��6+   �� 5N      $��Prénom gérant��6+   �� 5O      $��Adresse��6+   �� 5P      $��Tél gérant��6+   �� 5Q      $��Tél entreprise��6+   �� 5R      $��Mail gérant��6+   �� 5S      $��Mail entreprise��6+   �� 5T      $	��Web��6+   �� 5U      $��Source��6+   5X      �� 5Y      -   5         ��Name$ TBFiltresent��5Y   5   
�������$��1��6K   ���#82c4c86q   5Z      5\      5]      5^      5`      5a      