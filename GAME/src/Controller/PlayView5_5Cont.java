package Controller;

import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

import javax.swing.JButton;

import Management.BoardInformation5_5;

public class PlayView5_5Cont {
	private BoardInformation5_5 boardInfor;
	public PlayView5_5Cont(BoardInformation5_5 _boardInfor) {
		boardInfor = _boardInfor;
	}
	
	//盤にある駒を押したとき＞移動ボタンを表示させる
	public MouseAdapter OnBtnGoto() {
		
		MouseAdapter e = new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JButton clickedButton = (JButton) e.getSource();
				String zahyou = clickedButton.getActionCommand();
				int y = Integer.parseInt(zahyou.substring(0,1));
				int x = Integer.parseInt(zahyou.substring(1,2));
				boardInfor.checkClickedKoma(clickedButton, y, x);
			}
		};
		return e;
	}
	
	//盤にある駒を押した後、移動ボタンを押したとき＞駒を動かす
	public MouseAdapter OnBtnMove() {
		
		MouseAdapter e = new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JButton clickedButton = (JButton) e.getSource();
				String zahyou = clickedButton.getActionCommand();
				int gotoY = Integer.parseInt(zahyou.substring(0,1));
				int gotoX = Integer.parseInt(zahyou.substring(1,2));
				boardInfor.komaMove(gotoY, gotoX);

			}
		};
		return e;
	}
	//先手の持ち駒を押したとき＞移動ボタンを表示させる
	public MouseAdapter OnBtnHoldFirst() {
		
		MouseAdapter e = new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JButton clickedButton = (JButton) e.getSource();
				String holdName = clickedButton.getActionCommand();
				int holdLen = Integer.parseInt(holdName);
				int[] firstKomaCnt = boardInfor.getholdInforFirstKomaCnt();
				if(firstKomaCnt[holdLen] > 0) {
					boardInfor.checkClickedHoldKoma(true, holdLen);
				}
			}
		};
		return e;
	}
	
	//後手の持ち駒を押したとき＞移動ボタンを表示させる
	public MouseAdapter OnBtnHoldSecond() {
		
		MouseAdapter e = new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JButton clickedButton = (JButton) e.getSource();
				String holdName = clickedButton.getActionCommand();
				int holdLen = Integer.parseInt(holdName);
				int[] SecondKomaCnt = boardInfor.getholdInforSecondKomaCnt();
				if(SecondKomaCnt[holdLen] > 0) {
					boardInfor.checkClickedHoldKoma(false, holdLen);
				}
			}
		};
		return e;
	}
	
	//持ち駒を押した後、移動ボタンを押したとき＞持ち駒を動かす
	public MouseAdapter OnBtnHoldMove() {
		
		MouseAdapter e = new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JButton clickedButton = (JButton) e.getSource();
				String zahyou = clickedButton.getActionCommand();
				int gotoY = Integer.parseInt(zahyou.substring(0,1));
				int gotoX = Integer.parseInt(zahyou.substring(1,2));
				boardInfor.holdKomaMove(gotoY, gotoX);
			}
		};
		return e;
	}
}
