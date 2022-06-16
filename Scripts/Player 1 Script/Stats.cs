using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    //health
    public HealthBar hB;
    public StatsReplenish sR;
    public DiceController dC;

    public Text healthText;

    public Button summonDieButton;

    public float healthMax = 10;
    public float healthCurrent;

    public bool healthEmpty = false;
    public bool sButtonClicked = false;
    
    //mana
    public ManaBar mB;

    public Text manaText;

    public float manaMax = 5;
    public float manaCurrent;

    public bool manaEmpty = false;

    //sanity
    public SanityBar sB;

    public Text sanityText;

    public int sanityMax = 5;
    public int sanityCurrent;

    public bool sanityEmpty = false;

    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
        manaCurrent = manaMax;
        sanityCurrent = sanityMax;

        healthText.text = healthMax.ToString();
        manaText.text = manaMax.ToString();
        sanityText.text = sanityMax.ToString();

        hB.SetMaxHealth(healthMax);
        mB.SetMaxMana(manaMax);
        sB.SetMaxSanity(sanityMax);

        Button btn = summonDieButton.GetComponent<Button>();
        btn.onClick.AddListener(SummonDieButtonClicked);

    }

    // Update is called once per frame
    void Update()
    {
        if (sanityCurrent >= sanityMax)
        {
            StopCoroutine(sR.RefillStatsS());
            sanityCurrent = sanityMax;
        }      
        
        hB.SetHealth(healthCurrent);
        mB.SetMana(manaCurrent);
        sB.SetSanity(sanityCurrent);

        healthText.text = healthCurrent.ToString();
        manaText.text = manaCurrent.ToString();
        sanityText.text = sanityCurrent.ToString();

        Debug.Log("The current sanity is" + sanityCurrent);
    }

    void SummonDieButtonClicked()
    {
        StartCoroutine(sR.RefillStatsS());
    }
}
