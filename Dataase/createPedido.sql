CREATE TABLE pedidos (
    id SERIAL PRIMARY KEY,               -- Identificador único para cada pedido
    cliente_id INTEGER NOT NULL,         -- Referência ao cliente que fez o pedido
    data_emissao TIMESTAMP NOT NULL,     -- Data de emissão do pedido
    situacao VARCHAR(20) NOT NULL,       -- Situação do pedido (ex.: 'Pendente', 'Concluído', 'Cancelado')
    usuario_id INTEGER NOT NULL,         -- Referência ao usuário que inseriu o pedido
    data_inclusao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,  -- Data de inclusão do pedido no sistema
    
    -- Definir chave estrangeira para relacionar com a tabela de clientes
    CONSTRAINT fk_cliente
      FOREIGN KEY (cliente_id)
      REFERENCES clientes(id)
      ON DELETE CASCADE,

    -- Definir chave estrangeira para relacionar com a tabela de usuários
    CONSTRAINT fk_usuario
      FOREIGN KEY (usuario_id)
      REFERENCES usuarios(id)
      ON DELETE SET NULL
);