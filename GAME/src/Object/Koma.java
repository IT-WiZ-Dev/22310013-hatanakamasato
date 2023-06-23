package Object;

import java.awt.Point;
import java.awt.event.MouseAdapter;
import java.util.ArrayList;
import java.util.List;

import javax.swing.ImageIcon;
import javax.swing.JButton;

abstract public class Koma {
	protected FileNameCollection fileNameCollection = new FileNameCollection();
	protected int id;
	protected JButton b;
	protected int y;
	protected int x;
	protected boolean firstSecond;
	protected String nowFileName;
	protected String fileName;
	protected String fileNameSecond;
	protected int[] nowMove;
	protected int[] move;
	protected int[] moveSecond;
	public int getId() {return id;}
	public JButton getButton(){return b;}
	public int getY() {return y;}
	public int getX() {return x;}
	public void setButton(JButton _b) {b = _b;}
	public void setPoint(int y, int x) {
		this.y = y;
		this.x = x;
	}
	public void setNowFileName(String fileName) {nowFileName = fileName;}
	public String getNowFileName() {return nowFileName;}
	public String getFileName() {return fileName;}
	public String getFileNameSecond() {return fileNameSecond;}
	public boolean getFirstSecond() {return firstSecond;}

	
	//最初の現在の駒の状態
	public void setNowParameter() {
		if(firstSecond) {
			nowFileName = fileName;
			nowMove = move;

		}else {
			nowFileName = fileNameSecond;
			nowMove = moveSecond;
		}
	}
	//駒の動きを初期化
	public void initializeMove(String moveStg, String moveSecondStg){
		int moveNum = moveStg.length();
		move = new int[moveNum / 2];
		for(int i = 0, cnt = 0; i < moveNum; i += 2, cnt++) {
			move[cnt] = Integer.parseInt(moveStg.substring(i, i + 2));
		}
		int moveSecondNum = moveSecondStg.length();
		moveSecond = new int[moveSecondNum / 2];
		for(int i = 0, cnt = 0; i < moveSecondNum; i += 2, cnt++) {
			moveSecond[cnt] = Integer.parseInt(moveSecondStg.substring(i, i + 2));
		}
	}	
	

	
	public void createKomaB(MouseAdapter mouseAdapter) {
		b = new JButton();
		b.setBounds(getPointX(x), getPointY(y),100,100);// 65, 77);
		ImageIcon imageIcon = new ImageIcon(nowFileName);
		b.setIcon(imageIcon);
		
		//背景を透明化
		b.setContentAreaFilled(false);
		//枠線を消す
		b.setBorderPainted(false);
		b.setActionCommand( String.valueOf(y) + String.valueOf(x));
		b.addMouseListener(mouseAdapter);
		
	}

	
	//駒の移動先のボタンの座標を取得する
	public List<Integer> showGotoBtn(Koma[][] field) {
		List<Integer> list = new ArrayList<>();
		for(int i = 0; i < nowMove.length; i+=2) {
			int gotoY = nowMove[i] + y;
			int gotoX = nowMove[i + 1] + x;
			//盤の範囲内か
			if(gotoY >= 0 && gotoY <= 4 && gotoX >= 0&& gotoX <= 4) {
				//移動先に駒がないか
				if(isGotoExist(field, gotoY ,gotoX)) {
					//System.out.println(gotoY + " " + gotoX);
					list.add(gotoY);
					list.add(gotoX);
				}
			}
		}
		return list;
	}
	
	public boolean isGotoExist(Koma[][] field, int gotoY, int gotoX) {
		
		if(field[gotoY][gotoX] == null) {
			return true;
		}
		if(firstSecond ^ field[gotoY][gotoX].getFirstSecond()) {
			return true;
		}
		return false;
	}
	
	public void setHold(int holdCnt) {
		firstSecond = !firstSecond;
		setPoint(9, 9);
		b.setActionCommand( String.valueOf(9) + String.valueOf(9));
        Point newPosition = new Point(getHoldPointX(holdCnt),
        		                      getHoldPointY(holdCnt));
        setNowParameter();
		ImageIcon imageIcon = new ImageIcon(nowFileName);
		b.setIcon(imageIcon);
        b.setLocation(newPosition);
        
	}
	
	int getPointY(int y) {
		return 86 * y + 70;
	}
	int getPointX(int x) {
		return 70 * x + 210;
	}
	
	int getHoldPointY(int holdCnt) {
		if(firstSecond) {
			int pointCntY = holdCnt / 2;
		    return 86 * pointCntY + 328;
		}else {
			int pointCntY = holdCnt / 2;
		    return 86 * pointCntY + 70;
		}
		
	}
	int getHoldPointX(int holdCnt) {
		if(firstSecond) {
			return 70 * (holdCnt % 2) + 600;
		}else {
			return 70 * (holdCnt % 2);
		}
		
	}
	
	
	
	
	
	
}
