   M S B A M L   `   `   `  ����T  P301167069MelAnonuevo_Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:_301167069MelAnonuevo_Lab1_301167069MelAnonuevo_Lab1  5   	   '    !_301167069MelAnonuevo_Lab1.Create   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:_301167069MelAnonuevo_Lab1     5   	   -   5          � Title$  Create��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� -   5         ��Name$ BucketLabel��5
      $��Bucket Name: ��6%   $
��Left=�6=   $��	56,41,0,0q�6X   $	��Top=�6k   $��15(�6�   �� 5   
   -   5         ��Name$ BucketNameTextBox��5      $
��Left=�6-   $��
187,41,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��284��6�   $��30��6�   �� 5   
   -   5         ��Name$ createBucketBtn��5      $��Create Bucket��5      $
��Left=�5      $��
522,41,0,0q�5      $	��Top=�5      ���	#FFCCE91C���#6395EE$	��228��5      $��30��5      $��14(�5   +   $
��Bold"�69   $��Arial)�6K   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
BucketGrid��5      $��56,113,50,93q�6%      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Bucket Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Name+6S     5      $ Created Date��6%   $ 2* 6[    6;   �� *CreatedDate+6[   5      �� 5   
   -   5        $ backBtn��5      $��Back to the main window��5      $
��Left=�5      $��257,358,0,0q�5       $	��Top=�5!      $	��292��5"      $��38��5#      ���	#FFCCE91C���#6395EE$��Arial)�5%   "   $��14(�65   $
��Bold"�6C   6U   �� 5'   
   -   5        $ errorContentBox��5'      $
��Left=�6+   $��
187,76,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��550��6�   $��0,0,0,0q�6�   ���	#FF9862C96�   5(      5)      