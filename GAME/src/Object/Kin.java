package Object;

import java.awt.event.MouseAdapter;

public class Kin extends Koma {
	public Kin(int _y, int _x, MouseAdapter mouseAdapter, boolean _firstSecond){
		id = 4;
		y = _y;
		x = _x;
		firstSecond = _firstSecond;
		fileName = fileNameCollection.getKin();
		fileNameSecond = fileNameCollection.getKinSecond();
		initializeMove("-1-1-100-10100-100010100",
		              "-10000-1000101-101000101");
		//現在の動きと駒の画像を設定する
		setNowParameter();
		createKomaB(mouseAdapter);

	}
}
