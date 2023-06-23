package Object;

import java.awt.event.MouseAdapter;
import java.util.ArrayList;
import java.util.List;

public class Hisya extends KomaPromoted{
	public Hisya(int _y, int _x, MouseAdapter mouseAdapter, boolean _firstSecond){
		id = 2;
		y = _y;
		x = _x;
		firstSecond = _firstSecond;
		fileName = fileNameCollection.getHisya();
		fileNameSecond = fileNameCollection.getHisyaSecond();
		fileNamePromoted = fileNameCollection.getHisyaPromoted();
		fileNamePromotedSecond = fileNameCollection.getHisyaPromotedSecond();
		           
		initializeMove("-100-200-300-4000001000200030004010002000300040000-100-200-300-4",//先手の表の動き
			           "-100-200-300-4000001000200030004010002000300040000-100-200-300-4",//後手の表の動き
			           "-100-200-300-4000001000200030004010002000300040000-100-200-300-4-1-1-101010101-1",//先手の裏の動き
			           "-100-200-300-4000001000200030004010002000300040000-100-200-300-4-1-1-101010101-1");//後手の裏の動き

		//現在の動きと駒の画像を設定する
		setNowParameter();
		createKomaB(mouseAdapter);
	}

	
	
	public List<Integer> showGotoBtn(Koma[][] field) {
		List<Integer> list = new ArrayList<>();
		for(int i = 0; i < nowMove.length; i+=2) {
			int gotoY = nowMove[i] + y;
			int gotoX = nowMove[i + 1] + x;

			int isGotoNum = isNumGotoExist(field, gotoY ,gotoX);
			if(isGotoNum == 0 || isGotoNum == 1) {
				list.add(gotoY);
				list.add(gotoX);
			}
			if(isGotoNum == 1 || isGotoNum == 2) {
			    if(i < 32) {
				    if(i > 23) {
						i = 30;
				     }else if(i > 15) {
					   	i = 22;
				    }else if(i > 7) {
			     		i = 14;
			      	}else {
			    		i = 6;
			      	}
				}
			}
		}
		return list;
	}

	public int isNumGotoExist(Koma[][] field, int gotoY, int gotoX) {
		//範囲外
		if(gotoY < 0 || gotoY > 4 || gotoX < 0 || gotoX > 4) {
			return -1;
		}
		//座標を追加
		if(field[gotoY][gotoX] == null) {
			return 0;
		}
		//相手の駒なら座標を追加して次の直線に遷移
		if(firstSecond != field[gotoY][gotoX].getFirstSecond()) {
			return 1;
		}
		//もし自分の駒なら次の直線に遷移
		if(firstSecond == field[gotoY][gotoX].getFirstSecond()) {
			return 2;
		}
		//エラー
		return 999;
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
