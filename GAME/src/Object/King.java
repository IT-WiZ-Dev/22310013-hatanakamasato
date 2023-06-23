package Object;

import java.awt.event.MouseAdapter;

public class King extends Koma {
	public King(int _y, int _x, MouseAdapter mouseAdapter, boolean _firstSecond){
		id = 1;
		y = _y;
		x = _x;
		firstSecond = _firstSecond;
		fileName = fileNameCollection.getKing();
		fileNameSecond = fileNameCollection.getKingSecond();
		initializeMove("-1-1-100-10100-1000101-101000101",
				       "-1-1-100-10100-1000101-101000101");
		//現在の動きと駒の画像を設定する
		setNowParameter();
		createKomaB(mouseAdapter);

	}
}
