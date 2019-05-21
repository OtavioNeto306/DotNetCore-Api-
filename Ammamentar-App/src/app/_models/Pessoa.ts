export interface Pessoa {

    id: number;
    nome: string;
    email: string;
    senha: string;
    cpf: string;
    rg: string;
    telefone: string;
    celular: string;
    registroAtivo: number;
    dataCadastro: Date;
    enderecos: Endereco[];
}
