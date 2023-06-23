package Management;

import java.awt.Font;
import java.awt.Point;
import java.awt.event.MouseAdapter;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import Controller.PlayView5_5Cont;
import Object.Gin;
import Object.Hisya;
import Object.Hu;
import Object.Kaku;
import Object.Kin;
import Object.King;
import Object.Koma;
import Object.KomaPromoted;
import View.PlayView5_5;

public class BoardInformation5_5 {
	private PlayView5_5 playview;
	private PlayView5_5Cont cont = new PlayView5_5Cont(this);
	private HoldingInformation5_5 holdinfor = new HoldingInformation5_5(cont);

	private Koma[][] field = new Koma[5][5];
	private boolean nowFirstSecond = true;
	private int clickedY;
	private int clickedX;
	private JButton clickedKomaB;
	private int clickedHoldLen;
	private JButton[] movableSquareArr;

	public Koma[][] getField() {return field;}
	public JButton[] getHoldInforKomaBtn() {
		return holdinfor.getHoldKomaBtn();
	}
	public JLabel[] getHoldInforKomaLbl() {
		return holdinfor.getHoldKomaLbl();
	}
	public int[] getholdInforFirstKomaCnt() {
		return holdinfor.getHoldKomaFirstCnt();
	}
	public int[] getholdInforSecondKomaCnt() {
		return holdinfor.getHoldKomaSecondCnt();
	}
	public BoardInformation5_5(PlayView5_5 _playview) {
		playview = _playview;
		MouseAdapter mouseAdapter = cont.OnBtnGoto();
		field[4][0] = new King(4, 0, mouseAdapter, true);
		field[4][1] = new Kin(4, 1, mouseAdapter, true);
		field[4][2] = new Gin(4, 2, mouseAdapter, true);
		field[4][3] = new Kaku(4, 3, mouseAdapter, true);
		field[4][4] = new Hisya(4, 4, mouseAdapter, true);
		field[3][0] = new Hu(3, 0, mouseAdapter, true);
		
		field[0][4] = new King(0, 4, mouseAdapter,false);
		field[0][3] = new Kin(0, 3, mouseAdapter, false);
		field[0][2] = new Gin(0, 2, mouseAdapter, false);
		field[0][1] = new Kaku(0, 1, mouseAdapter, false);
		field[0][0] = new Hisya(0, 0, mouseAdapter, false);
		field[1][4] = new Hu(1, 4, mouseAdapter, false);

	}

	public void checkClickedKoma(JButton _clickedKomaB, int y, int x) {
		//クリックした駒は手番か
		if(field[y][x].getFirstSecond() == nowFirstSecond) {
			clickedKomaB = _clickedKomaB;
		    clickedY = y;
		    clickedX = x;
		    List<Integer> list  = field[y][x].showGotoBtn(field);
		    MouseAdapter mouseAdapter = cont.OnBtnMove();
		    createMovableSquare(list, mouseAdapter);
		}
	}
	public void komaMove(int gotoY, int gotoX) {	
		boolean winFlg = false;
		//移動できるマスのボタンを消す
		for(JButton movableSquare : movableSquareArr) {
			movableSquare.setVisible(false);  
		}
		
		//成れるかどうか
		if(isDoQuestion(field[clickedY][clickedX], gotoY)) {
			KomaPromoted kp = (KomaPromoted)field[clickedY][clickedX];
			//歩の場合成る
			if(kp.getId() == 8) {
				kp.promotedKoma();
			}else {
				//はい0　いいえ1
	      	    int result = showYesNoDialog("成りますか?");
	      	    if(result == 0) {
	      	    	kp.promotedKoma();
	      	    }
			}
		}
		//もし移動先に駒があれば
		if(field[gotoY][gotoX] != null) {
			//取った駒が王
			if(field[gotoY][gotoX].getId() == 1) {
				winFlg = true;
			}else {
				field[gotoY][gotoX].getButton().setVisible(false);
			    holdinfor.hold(field[gotoY][gotoX].getId(), nowFirstSecond);
			}
		}
		
		field[gotoY][gotoX] = field[clickedY][clickedX];
 		field[clickedY][clickedX] = null;
 		field[gotoY][gotoX].setPoint(gotoY, gotoX);
 		clickedKomaB.setActionCommand( String.valueOf(gotoY) + String.valueOf(gotoX));
        Point newPosition = new Point(getPointX(field[gotoY][gotoX].getX()),
        		                      getPointY(field[gotoY][gotoX].getY()));
        clickedKomaB.setLocation(newPosition);
        nowFirstSecond = !nowFirstSecond;
        if(winFlg) {
        	int num = showEndDialog("あなたの勝利です");
        	if(num == 0) {
        		playview.dispose();
        	}
        }
    }
	
	
	public void checkClickedHoldKoma(boolean _firstSecond, int holdLen) {
		//クリックした持ち駒は手番か
		if(nowFirstSecond == _firstSecond) {
			clickedHoldLen = holdLen;
			List<Integer> list  = holdinfor.getHoldListPoint(field, nowFirstSecond, holdLen);
			MouseAdapter mouseAdapter = cont.OnBtnHoldMove();			
			createMovableSquare(list, mouseAdapter);
		}
	}
	public void holdKomaMove(int gotoY, int gotoX) {
		//移動できるマスのボタンを消す
		for(JButton movableSquare : movableSquareArr) {
			movableSquare.setVisible(false);  
		}
		//持ち駒から指した駒をインスタンス化
		Koma koma = setInstancing(clickedHoldLen, gotoY, gotoX);
		field[gotoY][gotoX] = koma;
		JButton holdMoveBtn = koma.getButton();
		holdMoveBtn.setActionCommand( String.valueOf(gotoY) + String.valueOf(gotoX));
        Point newPosition = new Point(getPointX(field[gotoY][gotoX].getX()),
        		                      getPointY(field[gotoY][gotoX].getY()));
        holdMoveBtn.setLocation(newPosition);
        //持ち駒の数を減らす
        holdinfor.holdCntReduced(nowFirstSecond, clickedHoldLen);
        //持ち駒から指した駒を表示
        playview.showButton(holdMoveBtn);        
        nowFirstSecond = !nowFirstSecond;
	}
	
	public void createMovableSquare(List<Integer> listPoint, MouseAdapter mouseAdapter){
	    movableSquareArr = new JButton[listPoint.size() / 2];
		int cnt = 0;
		for(int i = 0; i < listPoint.size(); i+=2){
			JButton buttonGotoMasu = new JButton();
			buttonGotoMasu.setBounds(getPointX(listPoint.get(i + 1)), getPointY(listPoint.get(i)),100,100);
			buttonGotoMasu.setText("●");
			buttonGotoMasu.setFont(new Font("Arial", Font.BOLD, 50));
		    buttonGotoMasu.setContentAreaFilled(false);
		    buttonGotoMasu.setBorderPainted(false);
		    buttonGotoMasu.setActionCommand(String.valueOf(listPoint.get(i))
		                                  + String.valueOf(listPoint.get(i + 1)));
		    buttonGotoMasu.addMouseListener(mouseAdapter);
		    movableSquareArr[cnt++] = buttonGotoMasu;

		}
		playview.showMovableSquare(movableSquareArr);
	}
	
	

	
	private boolean isDoQuestion(Koma k, int gotoY) {
		//王の場合成れない
		if(k.getId() == 1) {return false;}
		
		//金の場合成れない
		if(k.getId() == 4) {return false;}
		
		//もともと成っている
		KomaPromoted kp = (KomaPromoted) k;
		if(kp.getIsPromoted()) {return false;}
		
		//敵陣じゃない場合成れない
		if(k.getFirstSecond()) {
			if(clickedY == 0) {
				return true;
			}
			if(gotoY > 0) {
				return false;
			}
		}else {
			if(clickedY == 4) {
				return true;
			}
			if(gotoY < 4) {
				return false;
			}
		}
		return true;
	}
	private Koma setInstancing(int holdLen, int gotoY, int gotoX){
		switch(holdLen){
		case 0:
			return new Hisya(gotoY, gotoX, cont.OnBtnGoto(), nowFirstSecond);
		case 1:
			return new Kaku(gotoY, gotoX, cont.OnBtnGoto(), nowFirstSecond);
		case 2:
			return new Kin(gotoY, gotoX, cont.OnBtnGoto(), nowFirstSecond);
		case 3:
			return new Gin(gotoY, gotoX, cont.OnBtnGoto(), nowFirstSecond);
		case 4:
			return new Hu(gotoY, gotoX, cont.OnBtnGoto(), nowFirstSecond);
		}
		System.out.println("持ち駒から指した駒がエラー");
		return null;
	}
	
	private int getPointY(int y) {
		return 86 * y + 70;
	}
	private int getPointX(int x) {
		return 70 * x + 210;
	}
	
	private int showYesNoDialog(String message) {
		return JOptionPane.showOptionDialog(
				null,
				message,
				"Confirmation",
				JOptionPane.YES_NO_OPTION,
				JOptionPane.QUESTION_MESSAGE,
				null,
				new Object[]{"はい", "いいえ"},
				"Yes");
	}
	private int showEndDialog(String endmessage) {
		return JOptionPane.showOptionDialog(
				null,
				endmessage,
				"Confirmation",
				JOptionPane.YES_NO_OPTION,
				JOptionPane.QUESTION_MESSAGE,
				null,
				new Object[]{"終わる", "終了図に戻る"},
				"Yes");
	}
	
	
}