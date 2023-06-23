package Object;

import java.awt.event.MouseAdapter;

public class Hu extends KomaPromoted{
	public Hu(int _y, int _x, MouseAdapter mouseAdapter, boolean _firstSecond){
		id = 8;
		y = _y;
		x = _x;
		firstSecond = _firstSecond;
		fileName = fileNameCollection.getHu();
		fileNameSecond = fileNameCollection.getHuSecond();
		fileNamePromoted = fileNameCollection.getHuPromoted();
		fileNamePromotedSecond = fileNameCollection.getHuPromotedSecond();
		initializeMove("-100",
			           "0100",
			           "-1-1-100-10100-100010100",
                       "-10000-1000101-101000101");

		//現在の動きと駒の画像を設定する
		setNowParameter();
		createKomaB(mouseAdapter);

	}
}
