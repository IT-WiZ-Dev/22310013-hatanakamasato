package Object;

import java.awt.event.MouseAdapter;

public class Gin extends KomaPromoted{
	public Gin(int _y, int _x, MouseAdapter mouseAdapter, boolean _firstSecond){
		id = 5;
		y = _y;
		x = _x;
		firstSecond = _firstSecond;
		fileName = fileNameCollection.getGin();
		fileNameSecond = fileNameCollection.getGinSecond();
		fileNamePromoted = fileNameCollection.getGinPromoted();
		fileNamePromotedSecond = fileNameCollection.getGinPromotedSecond();
		initializeMove("-1-1-100-10101-10101",
			           "01-101000101-1-1-101",
			           "-1-1-100-10100-100010100",
			           "-10000-1000101-101000101");

		//現在の動きと駒の画像を設定する
		setNowParameter();
		createKomaB(mouseAdapter);

	}
	public Gin() {}

}
