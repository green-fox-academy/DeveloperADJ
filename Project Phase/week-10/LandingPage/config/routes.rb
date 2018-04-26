Rails.application.routes.draw do
  #devise_for :admins

  devise_for :admins, path: 'auth', path_names: { sign_in: 'login', sign_out: 'logout', password: 'secret', confirmation: 'verification', unlock: 'unblock', registration: 'register', sign_up: 'cmon_let_me_in' }
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html

  get 'home/index'
  get 'admin/addproject', as: :addproject
  get 'admin/addteam', as: :addteam
  get 'admin/index', as: :admin
  get 'teams/show'
  resources :projects
  resources :teams
  resources :admin
  root :to => "home#index"
end
