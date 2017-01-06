import java.util.*;
public class asd {

	public static void main(String[] args)
	{
		Scanner input=new Scanner(System.in);
		char[][] graph=new char[3][3];
		for(int i=0;i<3;i++)
		{
			for(int l=0;l<3;l++)
				graph[i][l]=' ';
		}//for
		
		while(true){
			for(int i=0;i<graph.length;i++)
			{
				System.out.println("  "+graph[i][0]+"|  "+graph[i][1]+"|  "+graph[i][2]);
				if(i!=2)
					System.out.println("--------");
			}//for
			
			System.out.print("다음 수의 좌표를 입력하시오(3X3): ");
			int a=input.nextInt();
			int b=input.nextInt();
			
			if(graph[a][b]=='X')
			{
				System.out.print("중복입니다. 다시 입력하시오.");
			}//if
			else
			{
				graph[a][b]='X';
			}//else
			
			if( ( (graph[0][0]=='O') && (graph[0][1]=='O') && (graph[0][2]=='O') ) ||
					( (graph[1][0]=='O') && (graph[1][1]=='O') && (graph[1][2]=='O') ) ||
					( (graph[2][0]=='O') && (graph[2][1]=='O') && (graph[2][2]=='O') ) ||
					( (graph[0][0]=='O') && (graph[1][1]=='O') && (graph[2][2]=='O') ) ||
					( (graph[0][2]=='O') && (graph[1][1]=='O') && graph[2][0]=='O') )
			{
				System.out.print("ㅠ.ㅠ...Computer Win!");
				break;
			}//if
			else if( ( (graph[0][0]=='X')&&(graph[0][1]=='X')&&(graph[0][2]=='X') ) ||
				( (graph[1][0]=='X')&&(graph[1][1]=='X')&&(graph[1][2]=='X') ) ||
				( (graph[2][0]=='X')&&(graph[2][1]=='X')&&(graph[2][2]=='X') ) ||
				( (graph[0][0]=='X')&&(graph[1][1]=='X')&&(graph[2][2]=='X') ) ||
				( (graph[0][2]=='X')&&(graph[1][1]=='X')&&(graph[2][0]=='X') ) )
			{
				System.out.print("Congratulation! You Win!");
			}//else if
			
			while(true)
			{
				int m=(int)(Math.random()*3);
				int n=(int)(Math.random()*3);
				
				if(graph[m][n]=='O')
				{
					continue;
				}//if
				else
				{
				graph[m][n]='O';
				}//else
				
			}//while
			
			
		}//while
		
		
	}//main

}//class
