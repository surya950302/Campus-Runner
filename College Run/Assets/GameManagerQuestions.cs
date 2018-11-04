using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManagerQuestions : MonoBehaviour{

    //Making an array of questions class
    public Question[] questions;
    //creating a list of unanswered Questions
    private static List<Question> unanswered;

    //holds current question
    private Question current;

    //question text for UI
    [SerializeField]
    private Text quesText;

    //correctness in UI
    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text FalseAnswerText;

    //animator in UI
    [SerializeField]
    private Animator animator;

    //stores the delay
    [SerializeField]
    private float delay=1f;

    public Text Highscore;
    public int score;
    public int highscore;




    void Start()
    {
         if(unanswered == null || unanswered.Count == 0)
        {
            unanswered = questions.ToList<Question>();
        }

        SetCurrentQues();
        // Debug.Log(current.ques+" is "+current.isTrue);
    }
    void SetCurrentQues()
    {
        int RandomQuesIndex = Random.Range(0,unanswered.Count);
        current = unanswered[RandomQuesIndex];

        quesText.text= current.ques;
        
        if(current.isTrue)
        {
            trueAnswerText.text = "CORRECT";
            FalseAnswerText.text = "WRONG";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            FalseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQues()
    {
        //removing asnwered question from list
        unanswered.Remove(current);

        //Waiting for some seconds
        yield return new WaitForSeconds(delay);

        //load the scene with the index of current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
    }
    public void UserSelectYes()
    {
        animator.SetTrigger("True");
        if(current.isTrue)
        {
            //Score score = new Score();
            //string scoreNow = score.getScore();
			//Debug.Log(scoreNow);
			//gom.LoadGameOverUI();

            //Debug.Log(score);
            Time.timeScale = 1f;
			SceneManager.UnloadScene("MasterLevel");
        }
        else
        {
			//FindObjectOfType<Canvas>();
			Time.timeScale = 1f;
			SceneManager.LoadScene("GameOver");
			//FindObjectOfType<GameManager>().gameOverUI();
        	//gom.LoadGameOverUI();
            //Debug.Log("WRONG");
 
        }

        StartCoroutine(TransitionToNextQues());
    }

   
    public void UserSelectNo()
    {
        animator.SetTrigger("False");
        if (!current.isTrue)
        {
			//gom.LoadGameOverUI();
			Time.timeScale = 1f;
			SceneManager.UnloadScene("MasterLevel");
        }
        else
        {
        	//FindObjectOfType<GameManager>().gameOverUI();
			Time.timeScale = 1f;
			SceneManager.LoadScene("GameOver");
        	//FindObjectOfType<Canvas>();
        	//gom.LoadGameOverUI();
            //Debug.Log("WRONG");
			
        }

        StartCoroutine(TransitionToNextQues());
    }

	
}
