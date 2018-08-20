using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {

	public Text enemyLivesText;//text to print out the remaining lives
	public Image livesImage;//lives image
	public Sprite lives0Sprite;//the sprite image that will vchange with the display
	public Sprite lives1Sprite;//the sprite image that will vchange with the display
	public Sprite lives2Sprite;//the sprite image that will vchange with the display
	public Sprite lives3Sprite;//the sprite image that will vchange with the display
	public Image scoreImage1;//images forthr coins
	public Image scoreImage2;//images forthr coins
	public Image scoreImage3;//images forthr coins
	public Sprite score1Sprite;//the sprite image that will vchange with the display
	public Sprite score0Sprite;//the sprite image that will vchange with the display
	public void UpdateEnemyLives(int newEnemyLives){//creating this method t be public to be called uot by other classes
		string livesMsg = "Enemy has" + newEnemyLives;//printin out the remaining lives
		enemyLivesText.text = livesMsg;//making the string to apprear on gui
	}//end of updating the lives for the enemy
	public void UpdateScoreImage(int newScore){//updating score 
		switch(newScore){//initaiting the switch which makes the images much easier to change
		case 3:
			scoreImage3.sprite = score1Sprite;//saying that that particuar image is now another sprite
			break;
		case 2://saying that that particuar image is now another sprite
			scoreImage2.sprite = score1Sprite;
			break;
		case 1://saying that that particuar image is now another sprite
			scoreImage1.sprite = score1Sprite;
			break;
		case 0://making case 0 and default to be the same 
		default://saying that that particuar image is now another sprite
			scoreImage1.sprite = score0Sprite;
			break;
		}//end of switch statement
	}//end of updating the score method
	public void UpdateLivesImage(int newLives){//againthis is for the lives to be changed
		switch(newLives){//initiating a switch statement for this 
		case 3:
			livesImage.sprite = lives3Sprite;//making the lives image to appear as that sprite
			break;
		case 2:
			livesImage.sprite = lives2Sprite;//making the lives image to appear as that sprite
			break;
		case 1:
			livesImage.sprite = lives1Sprite;//making the lives image to appear as that sprite
			break;
		case 0:
		default://making case 0 and default to be the same 
			livesImage.sprite = lives1Sprite;//making the lives image to appear as that sprite
			break;
		}//end of swithc statement
	}//end of lives images update method
}//end of the main c;lass
