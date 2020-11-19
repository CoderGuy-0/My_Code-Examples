
import java.io.*;

/*
 * This program asks for input in menu format and gives input.
 * */

public class Main {

	public static void main(String[] args)throws IOException {
	BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	System.out.println("Welcome to program's menu");
	System.out.println("1. print values 1-10");
	System.out.println("2. print values 100-1");
	int opt = Integer.parseInt(br.readLine());
	switch(opt) {
	case 1:
		for(int i = 1;i<=10;i++) {
			System.out.println(i);
		}
		break;
	case 2:
		for(int j = 100;j>=1;j-- ) {
			System.out.println(j);
		}
		default: System.out.println("Wrong choise program will end!");
	}

	}

}
