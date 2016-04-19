package teste;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;


@ManagedBean(name = "ClassAutenticacao")
@SessionScoped
public class ClassAutenticacao {
	
	private String login;
	private String senha;
	private String mensagem;
	
	
	public String getLogin() {
		return login;
	}
	public void setLogin(String login) {
		this.login = login;
	}
	public String getSenha() {
		return senha;
	}
	public void setSenha(String senha) {
		this.senha = senha;
	}
	public String getMensagem() {
		return mensagem;
	}
	public void setMensagem(String mensagem) {
		this.mensagem = mensagem;
	}
	
	public String autenticarUsuario(){
		
		if(login.equals("vinicius")){
			
			mensagem = "Bem Vindo vinicius";
        }else{
        	mensagem = "Senha Inválida";
        }
			
    
    return null;

	}

}
