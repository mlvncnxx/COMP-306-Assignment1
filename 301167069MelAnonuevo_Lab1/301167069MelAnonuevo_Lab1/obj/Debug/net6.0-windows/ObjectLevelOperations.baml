   M S B A M L   `   `   `  ����T  P301167069MelAnonuevo_Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:_301167069MelAnonuevo_Lab1_301167069MelAnonuevo_Lab1  5   	   6    0_301167069MelAnonuevo_Lab1.ObjectLevelOperations   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:_301167069MelAnonuevo_Lab1     5   	   -   5          � Title$  ObjectLevelOperations��5   	   $	��450��6'   $	��800��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��87* �6   �� 5      $	��73* �6   .+�5   
   �� -   5         ��Name$ 
bucketName��5      $��Bucket��6$   $
��Left=�65   $��	46,24,0,0q�6P   $	��Top=�6c   �� 5   
   -   5         ��Name$ BucketListCombobox��5      $
��Left=�5      $��
122,21,0,0q�5      $	��Top=�5      $	��316��5      $��40��6   $��2��5      ��5      �� *	buckets+5      �� 5   
   $��Object��6   $
��Left=�6!   $��	46,83,0,0q�6<   $	��Top=�6O    J� RenderTransformOrigin$ 0.463,1.188&�6g   �� 5   
   -   5         ��Name$ objectTextBox��5      $
��Left=�6)   $��
122,76,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��316��6�   $��2��6�   $��40��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ObjectsGrid��5   (   $��10,135,0,22q�6      AutoGenerateColumns$ False��6;      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Object Name��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
ObjectName+6Y     5      $
	 Size��6%   $
 1* 6L    63   �� *Size+6L     5      $
 2* 6%   5!      �� 5"   
   -   5         ��Name$ 	browseBtn��5#      $��Browse��5$      $��Right=�5%      $��
0,93,182,0q�5&      $	��Top=�5'      ���#6395EE$	��128��5)      $��33��5*      ���	#FFCCE91C$��15(�60   $��1��6>   $
��Bold"�6N   6`   �� 5+   
   -   5        $ 	uploadBtn��5,      $��Upload��5-      $
��Left=�5.      $��
55,135,0,0q�5/      $	��Top=�50      ���#6395EE$	��128��52      $��33��53      ���	#FFCCE91C$��15(�60   $��1��6>   $
��Bold"�6N   6`   �� 54   
   -   5        $ backBtn��55      $��Back to Main Window
��56      $
��Left=�57      $��
23,334,0,0q�58      $	��Top=�59      ���#6395EE$	��196��5;      $��33��5<      ���	#FFCCE91C$��15(�60   $��1��6>   $
��Bold"�6N   6`   5=      5>      