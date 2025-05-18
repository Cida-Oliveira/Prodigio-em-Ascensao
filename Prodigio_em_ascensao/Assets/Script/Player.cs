using UnityEngine;

public class Player : MonoBehaviour
{
    //declaração de uma variável pública para controlar a velocidade do movimento do player
    public float velocidade;

    //método Start é chamado uma vez quando o script é iniciado
    void Start()
    {

    }

    // O método Update é chamado toda vez que um frame novo acontece (ou seja, o tempo todo enquanto o jogo roda).
    void Update()
    {
        //chama o método Move a cada frame para atualizar o movimento do player
        Move();
    }

    // Esse método aqui cuida do movimento do personagem.
    void Move()
    {
        // Aqui a gente pega o input do teclado: seta esquerda, seta direita, A ou D.
        // GetAxisRaw é mais direto – retorna -1 se for pra esquerda, 1 pra direita e 0 se nada for pressionado.
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);

        // Com esse valor de movimento, a gente muda a posição do personagem.
        // Time.deltaTime deixa o movimento suave e consistente, independente da taxa de quadros do jogo (FPS).
        transform.position += mov * Time.deltaTime * velocidade;

        // Se o jogador estiver apertando pra direita...
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            // ...fazemos o personagem olhar pra frente (direita).
            transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }

        // Se o jogador estiver apertando pra esquerda...
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            // ...viramos ele pra esquerda (gira no eixo Y).
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        /*if (Input.GetAxis("Horizontal") == of)
        {
            ele vai parar 
        }*/
    }
}
