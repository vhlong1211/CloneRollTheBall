using System.Collections;
using System.Collections.Generic;

public class DataConfig {
    //Map
    public static int[,] level1Map = new int[4,4]{{1,0,0,0},{11,0,0,5},{16,10,15,0},{-1,-1,-1,10}};
    public static int[,] level2Map = new int[4,4]{{1,0,0,0},{-1,9,-1,0},{9,0,10,-1},{16,-1,12,8}};
    public static int[,] level3Map = new int[4,4]{{1,0,0,0},{9,0,0,0},{9,10,0,0},{16,-1,12,8}};
    public static int[,] level4Map = new int[4,4]{{1,0,0,0},{16,9,0,-1},{9,-1,-1,-1},{10,0,12,8}};
    public static int[,] level5Map = new int[4,4]{{0,0,-1,1},{-1,-1,13,10},{13,14,9,9},{7,16,15,-1}};
    public static int[,] level6Map = new int[4,4]{{10,-1,10,8},{13,-1,9,0},{9,13,15,0},{3,-1,0,0}};
    public static int[,] level7Map = new int[4,4]{{-1,-1,-1,8},{-1,1,13,13},{0,9,9,9},{0,16,19,0}};
    public static int[,] level8Map = new int[4,4]{{-1,13,0,8},{4,1,-1,-1},{9,9,9,0},{0,20,19,-1}};
    public static int[,] level9Map = new int[4,4]{{-1,13,12,8},{1,9,-1,9},{11,0,0,0},{16,15,-1,9}};
    public static int[,] level10Map = new int[4,4]{{2,10,14,-1},{6,18,9,-1},{9,16,-1,9},{-1,0,15,-1}};
    public static int[,] level11Map = new int[4,4]{{2,12,14,-1},{6 ,14, 9 , -1},{16, -1, 9 ,-1},{0 , 0 , 0, 15}};
    public static int[,] level12Map = new int[4,4]{{2 ,10, 14, -1},{6 ,-1, -1, 14},{9,  9 , -1, 9},{0 , 16 ,0 , 15}};
    public static int[,] level13Map = new int[4,4]{{0, -1, 0, 0},{17, 10, 0 ,14},{3, -1, 16, 9},{-1, -1, 0 ,8}};
    public static int[,] level14Map = new int[4,4]{{10, 13 ,-1, 4},{20 ,14 ,-1 ,9},{10, -1 ,7 , 10},{-1 ,10,  0 ,-1}};
    public static int[,] level15Map = new int[4,4]{{2, 10, 9 ,18},{-1 ,9, -1 ,10},{10, 10, -1,11},{6, 12, 10, 19}};
    public static int[,] level16Map = new int[4,4]{{6 ,-1, 12, 14},{-1, 9, 10 ,0},{13, 10 ,10, 15},{20, 4  ,-1 ,-1}};
    public static int[,] level17Map = new int[4,4]{{13, -1, -1 ,14},{11, 10 ,-1, 9},{9 ,14 ,16 ,10},{3, 0, 9, 7}};
    public static int[,] level18Map = new int[4,4]{{16 ,13 ,14 ,14},{11 ,0, 12 ,-1},{7, -1 ,2 ,19},{-1, 0 ,16, 0}};
    public static int[,] level19Map = new int[4,4]{{0, 13, 14, -1},{2, 19 ,10, 9},{0 ,10, 9,-1},{0, 6, 0, 15}};
    public static int[,] level20Map = new int[4,4]{{0, -1, 13 ,18},{13, 19, 10, 0},{-1 ,9 ,13, 15},{3, 9 ,7, -1}};
    public static int[,] level21Map = new int[4,4]{{6, 15, -1, 10},{17, 14, -1, 0},{-1, 18 ,9 ,10},{16, 3,9, -1}};
    public static int[,] level22Map = new int[4,4]{{5, -1, 12, 4},{9, 13, -1 ,-1},{9, 16, 15, 13},{0, 0 ,0 ,0}};
    public static int[,] level23Map = new int[4,4]{{17, 10, 12, 4},{-1, 16 ,-1, 14},{10, 9 ,10, 5},{16, 9, 15, -1}};
    public static int[,] level24Map = new int[4,4]{{-1, 2,18, 0},{-1, 14, 9 ,-1},{16, 13, 15, -1},{6, 10, 15, 0}};
    public static int[,] level25Map = new int[4,4]{{-1, 10, 18, -1},{13, 17, -1, -1},{9, 9, 8, 0},{3, 16 ,0 ,15}};
    public static int[,] level26Map = new int[4,4]{{13, 14, 9 ,14},{3, 13 ,-1 ,7},{0, 20, -1 ,9},{0, 0 ,-1 ,15}};
    public static int[,] level27Map = new int[4,4]{{0 ,1 ,-1, -1},{0, 9, 10 ,14},{5, 10, 15, 16},{20 ,10 ,0 ,-1}};
    public static int[,] level28Map = new int[4,4]{{10, 13, 10, 14},{-1, 0, -1, -1},{9, 14 ,17 ,19},{3 ,16, -1, 8}};
    public static int[,] level29Map = new int[4,4]{{-1, 14, 2, 14},{14, 9 ,-1, 9},{6 , 13, 10, 15},{-1 ,20, 15 ,-1}};
    public static int[,] level30Map = new int[4,4]{{-1, 12, -1, 8},{13 ,9 ,10 ,-1},{9, 13, 10, 0},{3 ,0 ,-1 ,-1}};

    public static int[][,] mapAllLevel = new int[][,]{level1Map,level2Map,level3Map,level4Map,level5Map,level6Map,
    level7Map,level8Map,level9Map,level10Map,level11Map,level12Map,level13Map,level14Map,level15Map,level16Map,level17Map,
    level18Map,level19Map,level20Map,level21Map,level22Map,level23Map,level24Map,level25Map,level26Map,level27Map,level28Map,
    level29Map,level30Map};

    //Path
    public static Point[] level1Path = new Point[]{new Point(0,0),new Point(1,0),new Point(2,0),new Point(2,1),new Point(2,2),new Point(2,3),new Point(1,3)};
    public static Point[][] level1PathAll = new Point[][]{level1Path};
    public static Point[] level2Path = new Point[]{new Point(0,0),new Point(1,0),new Point(2,0),new Point(3,0),new Point(3,1),new Point(3,2),new Point(3,3)};
    public static Point[][] level2PathAll = new Point[][]{level2Path};
    public static Point[] level3Path = new Point[]{new Point(0,0),new Point(1,0),new Point(2,0),new Point(3,0),new Point(3,1),new Point(3,2),new Point(3,3)};
    public static Point[][] level3PathAll = new Point[][]{level3Path};
    public static Point[] level4Path = new Point[]{new Point(0,0),new Point(1,0),new Point(2,0),new Point(3,0),new Point(3,1),new Point(3,2),new Point(3,3)};
    public static Point[][] level4PathAll = new Point[][]{level4Path};
    public static Point[] level5Path = new Point[]{new Point(0,3),new Point(1,3),new Point(2,3),new Point(3,3),new Point(3,2),new Point(3,1),new Point(2,1),new Point(2,0),new Point(3,0)};
    public static Point[][] level5PathAll = new Point[][]{level5Path};
    public static Point[] level6Path1 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3)};
    public static Point[] level6Path2 = new Point[]{new Point(3,0),new Point(2,0),new Point(2,1),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3)};
    public static Point[] level6Path3 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(0,2),new Point(0,3)};
    public static Point[] level6Path4 = new Point[]{new Point(3,0),new Point(2,0),new Point(2,1),new Point(2,2),new Point(1,2),new Point(0,2),new Point(0,3)};
    public static Point[][] level6PathAll = new Point[][]{level6Path1,level6Path2,level6Path3,level6Path4};
    public static Point[] level7Path = new Point[]{new Point(1,1),new Point(2,1),new Point(3,1),new Point(3,2),new Point(2,2),new Point(1,2),new Point(0,2),new Point(0,3)};
    public static Point[][] level7PathAll = new Point[][]{level7Path};
    public static Point[] level8Path = new Point[]{new Point(1,1),new Point(2,1),new Point(3,1),new Point(3,2),new Point(2,2),new Point(1,2),new Point(0,2),new Point(0,3)};
    public static Point[][] level8PathAll = new Point[][]{level8Path};
    public static Point[] level9Path = new Point[]{new Point(1,0),new Point(2,0),new Point(3,0),new Point(3,1),new Point(2,1),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3)};
    public static Point[][] level9PathAll = new Point[][]{level9Path};
    public static Point[] level10Path1 = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(2,1),new Point(1,1),new Point(1,0)};
    public static Point[] level10Path2 = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,1),new Point(2,1),new Point(1,1),new Point(1,0)};
    public static Point[][] level10PathAll = new Point[][]{level10Path1,level10Path2};
    public static Point[] level11Path = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(2,1),new Point(1,1),new Point(1,0)};
    public static Point[][] level11PathAll = new Point[][]{level11Path};
    public static Point[] level12Path1 = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(2,1),new Point(1,1),new Point(1,0)};
    public static Point[] level12Path2 = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,1),new Point(2,1),new Point(1,1),new Point(1,0)};
    public static Point[] level12Path3 = new Point[]{new Point(0,0),new Point(0,1),new Point(1,1),new Point(1,0)};    
    public static Point[][] level12PathAll = new Point[][]{level12Path1,level12Path2,level12Path3};
    public static Point[] level13Path = new Point[]{new Point(2,0),new Point(1,0),new Point(1,1),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,3)};
    public static Point[][] level13PathAll = new Point[][]{level13Path};
    public static Point[] level14Path1 = new Point[]{new Point(0,3),new Point(0,2),new Point(1,2),new Point(2,2)};
    public static Point[] level14Path2 = new Point[]{new Point(0,3),new Point(0,2),new Point(0,1),new Point(0,0),new Point(1,0),new Point(1,1),new Point(1,2),new Point(2,2)};
    public static Point[][] level14PathAll = new Point[][]{level14Path1,level14Path2};
    public static Point[] level15Path = new Point[]{new Point(0,0),new Point(0,1),new Point(0,2),new Point(0,3),new Point(1,3),new Point(2,3),new Point(3,3),new Point(3,2),new Point(3,1),new Point(3,0)};
    public static Point[][] level15PathAll = new Point[][]{level15Path};
    public static Point[] level16Path1 = new Point[]{new Point(3,1),new Point(3,0),new Point(2,0),new Point(2,1),new Point(1,1),new Point(0,1),new Point(0,0)};
    public static Point[] level16Path2 = new Point[]{new Point(3,1),new Point(3,0),new Point(2,0),new Point(2,1),new Point(2,2),new Point(2,3),new Point(1,3),new Point(0,3),new Point(0,2),new Point(0,1),new Point(0,0)};
    public static Point[][] level16PathAll = new Point[][]{level16Path1,level16Path2};
    public static Point[] level17Path1 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(0,2),new Point(0,3),new Point(1,3),new Point(2,3),new Point(3,3)};
    public static Point[] level17Path2 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(1,1),new Point(1,2),new Point(1,3),new Point(2,3),new Point(3,3)};
    public static Point[] level17Path3 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(1,1),new Point(2,1),new Point(2,2),new Point(2,3),new Point(3,3)};
    public static Point[] level17Path4 = new Point[]{new Point(3,0),new Point(2,0),new Point(2,1),new Point(2,2),new Point(2,3),new Point(3,3)};
    public static Point[][] level17PathAll = new Point[][]{level17Path1,level17Path2,level17Path3,level17Path4};
    public static Point[] level18Path = new Point[]{new Point(2,2),new Point(2,3),new Point(1,3),new Point(1,2),new Point(1,1),new Point(0,1),new Point(0,0),new Point(1,0),new Point(2,0)};
    public static Point[][] level18PathAll = new Point[][]{level18Path};
    public static Point[] level19Path1 = new Point[]{new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,1)};
    public static Point[] level19Path2 = new Point[]{new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3),new Point(1,3),new Point(2,3),new Point(3,3),new Point(3,2),new Point(3,1)};
    public static Point[][] level19PathAll = new Point[][]{level19Path1,level19Path2};
    public static Point[] level20Path1 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3),new Point(1,3),new Point(2,3),new Point(2,2),new Point(3,2)};
    public static Point[] level20Path2 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,2),new Point(0,3),new Point(1,3),new Point(1,2),new Point(2,2),new Point(3,2)};    
    public static Point[][] level20PathAll = new Point[][]{level20Path1,level20Path2};
    public static Point[] level21Path1 = new Point[]{new Point(3,1),new Point(2,1),new Point(2,0),new Point(1,0),new Point(1,1),new Point(0,1),new Point(0,0)};
    public static Point[] level21Path2 = new Point[]{new Point(3,1),new Point(2,1),new Point(2,0),new Point(1,0),new Point(1,1),new Point(1,2),new Point(0,2),new Point(0,1),new Point(0,0)};
    public static Point[][] level21PathAll = new Point[][]{level21Path1,level21Path2};
    public static Point[] level22Path1 = new Point[]{new Point(0,3),new Point(0,2),new Point(0,1),new Point(1,1),new Point(1,0),new Point(0,0)};
    public static Point[] level22Path2 = new Point[]{new Point(0,3),new Point(0,2),new Point(0,1),new Point(1,1),new Point(2,1),new Point(2,0),new Point(1,0),new Point(0,0)};
    public static Point[][] level22PathAll = new Point[][]{level22Path1,level22Path2};
    public static Point[] level23Path1 = new Point[]{new Point(0,3),new Point(0,2),new Point(0,1),new Point(0,0),new Point(1,0),new Point(1,1),new Point(2,1),new Point(3,1),new Point(3,2),new Point(3,3),new Point(2,3)};
    public static Point[] level23Path2 = new Point[]{new Point(0,3),new Point(0,2),new Point(0,1),new Point(0,0),new Point(1,0),new Point(1,1),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,3),new Point(2,3)};
    public static Point[][] level23PathAll = new Point[][]{level23Path1,level23Path2};
    public static Point[] level24Path1 = new Point[]{new Point(0,1),new Point(0,2),new Point(1,2),new Point(2,2),new Point(2,1),new Point(3,1),new Point(3,0)};
    public static Point[] level24Path2 = new Point[]{new Point(0,1),new Point(0,2),new Point(1,2),new Point(1,3),new Point(2,3),new Point(2,2),new Point(3,2),new Point(3,1),new Point(3,0)};
    public static Point[][] level24PathAll = new Point[][]{level24Path1,level24Path2};
    public static Point[] level25Path = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(0,2),new Point(1,2),new Point(1,1),new Point(2,1),new Point(2,2)};
    public static Point[][] level25PathAll = new Point[][]{level25Path};
    public static Point[] level26Path = new Point[]{new Point(1,0),new Point(0,0),new Point(0,1),new Point(1,1),new Point(2,1),new Point(2,2),new Point(1,2),new Point(0,2),new Point(0,3),new Point(1,3)};
    public static Point[][] level26PathAll = new Point[][]{level26Path};
    public static Point[] level27Path1 = new Point[]{new Point(0,1),new Point(1,1),new Point(2,1),new Point(2,2),new Point(3,2),new Point(3,1),new Point(3,0),new Point(2,0)};
    public static Point[] level27Path2 = new Point[]{new Point(0,1),new Point(1,1),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,1),new Point(3,0),new Point(2,0)};
    public static Point[][] level27PathAll = new Point[][]{level27Path1,level27Path2};
    public static Point[] level28Path1 = new Point[]{new Point(3,0),new Point(2,0),new Point(2,1),new Point(3,1),new Point(3,2),new Point(3,3)};
    public static Point[] level28Path2 = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(1,1),new Point(1,2),new Point(1,3),new Point(2,3),new Point(2,2),new Point(3,2),new Point(3,3)};
    public static Point[][] level28PathAll = new Point[][]{level28Path1,level28Path2};
    public static Point[] level29Path1 = new Point[]{new Point(0,2),new Point(0,3),new Point(1,3),new Point(2,3),new Point(2,2),new Point(3,2),new Point(3,1),new Point(2,1),new Point(2,0)};
    public static Point[] level29Path2 = new Point[]{new Point(0,2),new Point(0,3),new Point(1,3),new Point(1,2),new Point(2,2),new Point(2,1),new Point(2,0)};
    public static Point[] level29Path3 = new Point[]{new Point(0,2),new Point(0,3),new Point(1,3),new Point(1,2),new Point(2,2),new Point(3,2),new Point(3,1),new Point(2,1),new Point(2,0)};
    public static Point[][] level29PathAll = new Point[][]{level29Path1,level29Path2,level29Path3};
    public static Point[] level30Path = new Point[]{new Point(3,0),new Point(2,0),new Point(1,0),new Point(0,0),new Point(0,1),new Point(0,2),new Point(0,3)};
    public static Point[][] level30PathAll = new Point[][]{level30Path};


    public static Point[][][] pathAllLevel = new Point[][][]{level1PathAll,level2PathAll,level3PathAll,level4PathAll,level5PathAll,level6PathAll,
    level7PathAll,level8PathAll,level9PathAll,level10PathAll,level11PathAll,level12PathAll,level13PathAll,level14PathAll,level15PathAll,level16PathAll,
    level17PathAll,level18PathAll,level19PathAll,level20PathAll,level21PathAll,level22PathAll,level23PathAll,level24PathAll,level25PathAll,level26PathAll,
    level27PathAll,level28PathAll,level29PathAll,level30PathAll};
    //value
    public static int[] level1PathValue = new int[]{1,11,16,10,10,15,5};
    public static int[][] level1PathValueAll = new int[][]{level1PathValue};
    public static int[] level2PathValue = new int[]{1,9,9,16,10,12,8};
    public static int[][] level2PathValueAll = new int[][]{level2PathValue};
    public static int[] level3PathValue = new int[]{1,9,9,16,10,12,8};
    public static int[][] level3PathValueAll = new int[][]{level3PathValue};
    public static int[] level4PathValue = new int[]{1,9,9,16,10,12,8};
    public static int[][] level4PathValueAll = new int[][]{level4PathValue};
    public static int[] level5PathValue = new int[]{1,9,9,15,10,16,14,13,7};
    public static int[][] level5PathValueAll = new int[][]{level5PathValue};
    public static int[] level6PathValue1 = new int[]{3,9,13,15,13,10,8};
    public static int[] level6PathValue2 = new int[]{3,13,15,9,13,10,8};
    public static int[] level6PathValue3 = new int[]{3 ,9, 9, 13, 10, 10, 8};
    public static int[] level6PathValue4 = new int[]{3, 13, 10 ,15, 9 ,13, 8};
    public static int[][] level6PathValueAll = new int[][]{level6PathValue1,level6PathValue2,level6PathValue3,level6PathValue4};
    public static int[] level7PathValue = new int[]{1,9,16,19,9,9,13,8};
    public static int[][] level7PathValueAll = new int[][]{level7PathValue};
    public static int[] level8PathValue = new int[]{1,9,20,19,9,9,13,8};
    public static int[][] level8PathValueAll = new int[][]{level8PathValue};
    public static int[] level9PathValue = new int[]{1,11,16,15,9,9,13,12,8};
    public static int[][] level9PathValueAll = new int[][]{level9PathValue};
    public static int[] level10PathValue1 = new int[]{2,10,14,9,15,16,18,6};
    public static int[] level10PathValue2 = new int[]{2,10,14,9,9,15,16,9,18,6};
    public static int[][] level10PathValueAll = new int[][]{level10PathValue1,level10PathValue2};
    public static int[] level11PathValue = new int[]{2, 12, 14 ,9 ,15, 16 ,14, 6};    
    public static int[][] level11PathValueAll = new int[][]{level11PathValue};
    public static int[] level12PathValue1 = new int[]{2, 10, 14 ,9, 15 ,16 ,14 ,6};    
    public static int[] level12PathValue2 = new int[]{2, 10, 14 ,9 ,9 ,15,16, 9 ,14 ,6};  
    public static int[] level12PathValue3 = new int[]{2, 14,15,6};  
    public static int[][] level12PathValueAll = new int[][]{level12PathValue1,level12PathValue2,level12PathValue3};
    public static int[] level13PathValue = new int[]{3, 17, 10 ,14,9 ,16, 8};    
    public static int[][] level13PathValueAll = new int[][]{level13PathValue};
    public static int[] level14PathValue1 = new int[]{4, 13 ,9 ,7};    
    public static int[] level14PathValue2 = new int[]{4, 10, 10 ,13, 20, 10, 14, 7};    
    public static int[][] level14PathValueAll = new int[][]{level14PathValue1,level14PathValue2};
    public static int[] level15PathValue = new int[]{2 ,10, 10, 18, 9 ,11, 19, 10 ,12, 6};    
    public static int[][] level15PathValueAll = new int[][]{level15PathValue};
    public static int[] level16PathValue1 = new int[]{4 ,20, 13, 15 ,9 ,14, 6};    
    public static int[] level16PathValue2 = new int[]{4 ,20 ,13 ,10 ,10 ,15 ,9 ,14, 12, 10 ,6};    
    public static int[][] level16PathValueAll = new int[][]{level16PathValue1,level16PathValue2};
    public static int[] level17PathValue1 = new int[]{3, 9, 11 ,13 ,10 ,10, 14 ,9, 9 ,7};
    public static int[] level17PathValue2 = new int[]{3, 9, 11 ,13 ,14 ,16, 10 ,14 ,9, 7};    
    public static int[] level17PathValue3 = new int[]{3, 9, 11 ,13 ,14 ,9 ,16 ,10 ,14 ,7};    
    public static int[] level17PathValue4 = new int[]{3 ,13, 10 ,10 ,14, 7};     
    public static int[][] level17PathValueAll = new int[][]{level17PathValue1,level17PathValue2,level17PathValue3,level17PathValue4};
    public static int[] level18PathValue = new int[]{2, 19, 14, 12 ,16 ,14, 13, 11, 7};    
    public static int[][] level18PathValueAll = new int[][]{level18PathValue};
    public static int[] level19PathValue1 = new int[]{2, 19, 13 ,14, 9 ,9,15, 6};    
    public static int[] level19PathValue2 = new int[]{2, 19, 13, 10 ,14 ,9, 9 ,15, 10 ,6};    
    public static int[][] level19PathValueAll = new int[][]{level19PathValue1,level19PathValue2};
    public static int[] level20PathValue1 = new int[]{3, 9, 13, 19, 13, 10 ,18, 9 ,15 ,13, 7}; 
    public static int[] level20PathValue2 = new int[]{3, 9, 13, 19, 13, 10 ,18, 15 ,13 ,9, 7}; 

    public static int[][] level20PathValueAll = new int[][]{level20PathValue1,level20PathValue2};
    public static int[] level21PathValue1 = new int[]{3, 18, 16 ,17 ,15 ,14, 6}; 
    public static int[] level21PathValue2 = new int[]{3, 18, 16, 17 ,10 ,15, 14, 10, 6}; 
    public static int[][] level21PathValueAll = new int[][]{level21PathValue1,level21PathValue2};
    public static int[] level22PathValue1 = new int[]{4, 12, 13 ,15, 16 ,5}; 
    public static int[] level22PathValue2 = new int[]{4, 12, 13 ,9 ,15 ,16, 9, 5}; 
    public static int[][] level22PathValueAll = new int[][]{level22PathValue1,level22PathValue2};
    public static int[] level23PathValue1 = new int[]{4, 12 ,10 ,17, 16 ,14 ,9, 16 ,10,15, 5}; 
    public static int[] level23PathValue2 = new int[]{4, 12 ,10 ,17 ,16 ,10 ,14 ,9 ,16 ,15, 5}; 
    public static int[][] level23PathValueAll = new int[][]{level23PathValue1,level23PathValue2};
    public static int[] level24PathValue1 = new int[]{2, 18, 9 ,15, 13, 15 ,6}; 
    public static int[] level24PathValue2 = new int[]{2, 18 ,16 ,14 ,15 ,13 ,15 ,10, 6}; 
    public static int[][] level24PathValueAll = new int[][]{level24PathValue1,level24PathValue2};
    public static int[] level25PathValue = new int[]{3, 9, 9 ,13, 10, 18 ,15 ,17 ,16,8}; 
    public static int[][] level25PathValueAll = new int[][]{level25PathValue};
    public static int[] level26PathValue = new int[]{3, 13, 14 ,9 ,20, 15, 9 ,13 ,14 ,7}; 
    public static int[][] level26PathValueAll = new int[][]{level26PathValue};
    public static int[] level27PathValue1 = new int[]{1, 9 ,16 ,14 ,15, 10, 20 ,5}; 
    public static int[] level27PathValue2 = new int[]{1, 16, 14, 9, 15 ,10 ,20, 5}; 
    public static int[][] level27PathValueAll = new int[][]{level27PathValue1,level27PathValue2};
    public static int[] level28PathValue1 = new int[]{3, 13 ,14, 16, 10, 8}; 
    public static int[] level28PathValue2 = new int[]{3, 9, 13, 10 ,10, 14 ,19, 17, 16 ,8}; 
    public static int[][] level28PathValueAll = new int[][]{level28PathValue1,level28PathValue2};
    public static int[] level29PathValue1 = new int[]{2, 14, 9, 15, 13, 15 ,20 ,14, 6}; 
    public static int[] level29PathValue2 = new int[]{2 ,14 ,15 ,13 ,15, 10, 6}; 
    public static int[] level29PathValue3 = new int[]{2, 14, 15 ,13, 9 ,15, 20 ,14 ,6}; 
    public static int[][] level29PathValueAll = new int[][]{level29PathValue1,level29PathValue2,level29PathValue3};
    public static int[] level30PathValue = new int[]{3 ,9 ,9 ,13, 12, 10 ,8}; 
    public static int[][] level30PathValueAll = new int[][]{level30PathValue};



    public static int[][][] pathValueAllLevel = new int[][][]{level1PathValueAll,level2PathValueAll,level3PathValueAll,level4PathValueAll
    ,level5PathValueAll,level6PathValueAll,level7PathValueAll,level8PathValueAll,level9PathValueAll,level10PathValueAll
    ,level11PathValueAll,level12PathValueAll,level13PathValueAll,level14PathValueAll,level15PathValueAll,
    level16PathValueAll,level17PathValueAll,level18PathValueAll,level19PathValueAll,level20PathValueAll,level21PathValueAll,
    level22PathValueAll,level23PathValueAll,level24PathValueAll,level25PathValueAll,level26PathValueAll,level27PathValueAll,
    level28PathValueAll,level29PathValueAll,level30PathValueAll};

}

public struct Point
 {
     public int x, y;
     public Point(int px, int py)
     {
         x = px;
         y = py;
     }
 }