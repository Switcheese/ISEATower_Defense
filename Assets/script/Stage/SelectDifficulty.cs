using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectDifficulty : MonoBehaviour
{

    [SerializeField]
    Text m_text;
    [SerializeField]
    int IndexDifficulty = 1;

    public void ChangeText()
    {

        IndexDifficulty++;
        if (IndexDifficulty > 3)
        {
            IndexDifficulty = 1;
        }

        switch (IndexDifficulty)
        {
            case 1:
                m_text.text = "Nomal";
                break;
            case 2:
                m_text.text = "Hard";
                break;
            case 3:
                m_text.text = "Master";
                break;
        }

    }

}
