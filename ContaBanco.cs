
public class ContaBanco
{
    public int numConta;
    protected char tipo;
    private string dono;
    private float saldo;
    private bool status;

    public void estadoAtual()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Conta: " + this.getNumConta());
        Console.WriteLine("Tipo: " + this.getTipo());
        Console.WriteLine("Dono: " + this.getDono());
        Console.WriteLine("Saldo: " + this.getSaldo());
        Console.WriteLine("Status: " + this.getStatus());


    }

    public ContaBanco()
    {
        
        this.setSaldo(0);
        this.setStatus(false);


    }

    public int getNumConta()
    {
        return this.numConta;
    }
    public void setNumConta(int n)
    {
        this.numConta = n;
    }
    public char getTipo()
    {
        return this.tipo;
    }
    public void setTipo(char t)
    {
        this.tipo = t;
    }
    public string getDono()
    {
        return this.dono;
    }
    public void setDono(string d)
    {
        this.dono = d;
    }
    public float getSaldo()
    {
        return this.saldo;
    }
    public void setSaldo(float s)
    {
        this.saldo = s;
    }
    public bool getStatus()
    {
        return this.status;
    }
    public void setStatus(bool st)
    {
        this.status = st;
    }

    public void abrirConta(char t)
    {
        this.setStatus(true);
        this.setTipo(t);
        if (t == 'c')
        {
            this.setSaldo(50);
        }
        else if (t == 'p')
        {
            this.setSaldo(150);
        }
        Console.WriteLine("Conta aberta com sucesso");
    }
    public void fecharConta()
    {
        if (this.getSaldo() > 0)
        {
            Console.WriteLine("Conta com Dinheiro");
        }
        else if (this.getSaldo() < 0)
        {
            Console.WriteLine("Conta em débito");
        }
        else
        {
            setStatus(false);
            Console.WriteLine("Conta fechada com sucesso");
        }
    }

    public void depositar(float v)
    {
        if (this.getStatus())
        {
            this.setSaldo(this.getSaldo() + v);
            Console.WriteLine("Deposito realizado na conta de " + this.getDono());
        }
        else
        {
            Console.WriteLine("Impossível depositar");
        }
    }
    public void sacar(float v)
    {
        if (this.getStatus())
        {
            if (this.getSaldo() >= v)
            {
                this.setSaldo(this.getSaldo() - v);
                Console.WriteLine("Saque realizado na conta de " + this.getDono());
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Impossível sacar");
        }
    }
    public void pagarMensal()
    {
        int v = 0;
        if (this.getTipo() == 'c')
        {
            v = 12;
        }
        else if (this.getTipo() == 'p')
        {
            v = 20;
        }
        if (this.getStatus())
        {
            this.setSaldo(this.getSaldo() - v);
            Console.WriteLine("Mensalidade paga com sucesso por " + this.getDono());
        }
        else
        {
            Console.WriteLine("Impossivel pagar uma conta fechada");
        }
    }
}