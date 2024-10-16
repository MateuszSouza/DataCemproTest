CREATE TABLE usuarios (
    id SERIAL PRIMARY KEY,         -- Identificador único para cada usuário
    nome VARCHAR(30) NOT NULL,     -- Nome com limite de 30 caracteres
    username VARCHAR(50) NOT NULL UNIQUE,  -- Nome de usuário único
    senha VARCHAR(10) NOT NULL,   -- Senha (idealmente um hash, como bcrypt)
    nivel CHAR(18) NOT NULL,        -- Nível de acesso (por exemplo, 1 para admin, 2 para usuário comum, etc.)
    ativo_sn BOOLEAN NOT NULL DEFAULT TRUE,  -- Indicador se o usuário está ativo (S/N -> true/false)
);

-- Criar índice para buscar usuários rapidamente por username
CREATE INDEX idx_username ON usuarios(username);
