class AdminController < ApplicationController

  before_action :authenticate_admin!

  def login
  end

  def index
    @projects = Project.all
    @teams = Team.all
  end

end
