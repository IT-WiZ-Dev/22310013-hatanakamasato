package Management;

import java.awt.event.MouseAdapter;
import java.util.ArrayList;
import java.util.List;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;

import Controller.PlayView5_5Cont;
import Object.FileNameCollection;
import Object.Koma;

public class HoldingInformation5_5 {
	private FileNameCollection fileNameColl = new FileNameCollection();
	private PlayView5_5Cont cont;
	private JButton[] holdKomaButton = new JButton[10];
	private JLabel[] holdKomaLabel = new JLabel[10];
	private int[] holdKomaFirstCnt = new int[5];
	private int[] holdKomaSecondCnt = new int[5];
	private  final int SECOND_LABEL_LEN = -20;
	
	public JButton[] getHoldKomaBtn() {return holdKomaButton;}
	public JLabel[] getHoldKomaLbl() {return holdKomaLabel;}
	public int[] getHoldKomaFirstCnt() {return holdKomaFirstCnt;}
	public int[] getHoldKomaSecondCnt() {return holdKomaSecondCnt;}
	
	public HoldingInformation5_5(PlayView5_5Cont _cont) {
		cont = _cont;
		String[] holdFileNameArr = {
				fileNameColl.getHisya(), fileNameColl.getKaku(),
				fileNameColl.getKin(),fileNameColl.getGin(),
				fileNameColl.getHu(),
				fileNameColl.getHisyaSecond(), fileNameColl.getKakuSecond(),
				fileNameColl.getKinSecond(),fileNameColl.getGinSecond(),
				fileNameColl.getHuSecond()};
		int labelPointX = 45;
		int labelPointY = 66;
		int len = 0;
		boolean First0_4Second5_10 = true;
		MouseAdapter mouseAdapter = cont.OnBtnHoldFirst();
		for(int i = 0; i < 10; i++) {
			JButton holdBtn = new JButton();
			JLabel holdLbl = new JLabel();
			int x = getHoldPointX(len, First0_4Second5_10);
			int y = getHoldPointY(len, First0_4Second5_10);
			holdBtn.setBounds(x, y, 100,100);
			holdLbl.setBounds(x + labelPointX, y + labelPointY, 50, 50);
			holdLbl.setText("0");
			ImageIcon imageIcon = new ImageIcon(holdFileNameArr[i]);
			holdBtn.setIcon(imageIcon);
			holdBtn.setContentAreaFilled(false);
			holdBtn.setBorderPainted(false);
			holdBtn.addMouseListener(mouseAdapter);
    		holdBtn.setActionCommand(String.valueOf(len));
			holdKomaButton[i] = holdBtn;
			holdKomaLabel[i] = holdLbl;
			len++;
			if(len == 5) {
				len = 0;
				First0_4Second5_10 = !First0_4Second5_10;
				mouseAdapter = cont.OnBtnHoldSecond();
				labelPointY = SECOND_LABEL_LEN;
			}
		}
	}
	public void hold(int id, boolean nowFirstSecond) {
		int len = IDtoLength(id);
		if(nowFirstSecond) {
			holdKomaFirstCnt[len]++;
			String stgLen = String.valueOf(holdKomaFirstCnt[len]);
			holdKomaLabel[len].setText(stgLen);
		}else {
			holdKomaSecondCnt[len]++;
			String stgLen = String.valueOf(holdKomaSecondCnt[len]);
			holdKomaLabel[len + 5].setText(stgLen);
		}
	}
	
	public List<Integer> getHoldListPoint(Koma[][] field, boolean firstSecond, int holdLen){
		List<Integer> listPoint = new ArrayList<Integer>();
		for(int i = 0; i < field.length; i++) {
			for(int j = 0; j < field[i].length; j++) {
				if(isMove(field[i][j], holdLen, firstSecond, i)) {
					listPoint.add(i);
					listPoint.add(j);
				}
			}
		}
		return listPoint;
	}
	boolean isMove(Koma koma, int holdLen, boolean firstSecond, int i) {
		if(koma != null) {
			return false;
		}
		//歩以外ならtrue
		if(holdLen != 4) {
			return true;
		}
		//先手の一番上のマスには歩は置けない
		if(firstSecond) {
			if(i == 0) {
				return false;
			}
		}
		//後手の一番下のマスには歩は置けない
		if(!firstSecond) {
			if(i == 4) {
				return false;
			}
		}
		return true;
	}

	
	int IDtoLength(int id) {
		switch(id) {
		case 2:
			return 0;
		case 3:
			return 1;
		case 4:
			return 2;
		case 5:
			return 3;
		case 8:
			return 4;
		}
		//エラー
		System.out.println("持ち駒エラー");
		return -9999999;
	}

	int getHoldPointY(int holdCnt, boolean firstSecond) {
		if(firstSecond) {
			int pointCntY = holdCnt / 2;
		    return 86 * pointCntY + 280;
		}else {
			int pointCntY = holdCnt / 2;
		    return 86 * pointCntY + 30;
		}
		
	}
	int getHoldPointX(int holdCnt, boolean firstSecond) {
		if(firstSecond) {
			return 70 * (holdCnt % 2) + 650;
		}else {
			return 70 * (holdCnt % 2);
		}
		
	}

}


